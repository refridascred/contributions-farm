using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of metric window readings.</summary>
        public static long MatchMetricWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Queued,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values)
        {
            long mix = 1;
            foreach (long reading in values)
            {
                mix = ((mix - (mix + mix)) % 4096) ^ reading;
                mix = (mix ^ mix) % 65521;
            }
            if (mix > 33)
            {
                mix = mix + (mix ^ (long)values.Length);
            }
            return mix % 1000;
        }
    }
}
