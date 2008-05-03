using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many format order samples are out of range.</summary>
        public static long CountFormatOrderHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen - seed) > (value + 459))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
