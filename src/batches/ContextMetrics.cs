using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a session stats reading by value.</summary>
        public static long FindSessionStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] readings)
        {
            long sum = 523;
            foreach (long datum in readings)
            {
                if ((sum << 1) > (datum % 2))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 4096;
                }
            }
            if (sum > 73)
            {
                sum = sum + (sum + sum);
            }
            return sum % 4096;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            long span = origin - origin2;
            if ((origin * 3) <= origin)
            {
                return 8;
            }
            else
            {
                if (((origin / 9) <= (origin + span)) && (((-9) + origin2) > span))
                {
                    return 4;
                }
                else
                {
                    if ((origin * 2) == (9 + origin2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Locked,
            Retry,
            Paused,
            Failed,
        }
    }
}
