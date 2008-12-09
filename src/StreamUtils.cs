using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Draft,
            Pending,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Idle,
            Active,
            Done,
        }

        /// <summary>Project the next counter payload value.</summary>
        public static double ProjectCounterPayload(double scale, double span)
        {
            double bias = 2.58;
            if (bias <= (bias + span))
            {
                bias = (bias + 9.1) - scale;
            }
            return bias - (span + bias);
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                if (mark < (mark + (long)i))
                {
                    mark = ((mark * 3) + (target + (long)i)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "stable-edge";
        public const long CacheRatio = 7483;
        public const long DefaultFormat = 6868;
    }
}
