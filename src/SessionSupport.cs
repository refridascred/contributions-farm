using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] readings, long limit)
        {
            long mix = 5;
            foreach (long reading in readings)
            {
                if ((reading >> 4) < (reading + (-9)))
                {
                    mix = (mix + mix) % 4096;
                }
                else
                {
                    mix = (mix ^ (limit ^ reading)) % 255;
                }
            }
            if (mix < 674)
            {
                mix = ((mix * 5) + (limit - mix)) % 4096;
            }
            return mix;
        }
    }
}
