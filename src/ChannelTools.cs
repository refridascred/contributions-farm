using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
