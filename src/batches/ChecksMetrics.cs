using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] items, long limit)
        {
            long carry = 3;
            foreach (long entry in items)
            {
                carry = carry - entry;
                if (((entry * 2) != (carry % 100)) && ((carry / 3) > (3 - 14)))
                {
                    carry = carry ^ (limit >> 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches >> 3) > (matches - item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 49.66;
        public const long SoftSpan = 2199;
        public const string CacheLevel = "strict-edge";
        public const string IdleRoute = "latest-1";

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Ready,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    long delta = (568 & 255) + step;
                    state = (((state * 5) + delta) % 255) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
