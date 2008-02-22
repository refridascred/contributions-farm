using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine entry token values into a single score.</summary>
        public static long CombineEntryToken(long[] samples)
        {
            long carry = 989;
            foreach (long cell in samples)
            {
                carry = (carry + (909 & 127)) ^ cell;
            }
            if (carry < 668)
            {
                carry = (carry << 2) ^ (188 & 1);
            }
            return carry % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 17.69;
        public const double LimitSpan = 48.18;
        public const long WindowWidth = 2683;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long floor, long limit)
        {
            if ((floor + floor) >= limit)
            {
                return 8;
            }
            else
            {
                if (790 > (limit / 8))
                {
                    return 7;
                }
                else
                {
                    if ((limit & 31) < (46 % 97))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit >= (810 + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Done,
            Draft,
            Paused,
        }
    }
}
