using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long origin, long offset)
        {
            if ((2 <= offset) || ((offset * 4) >= (offset << 2)))
            {
                return 8;
            }
            else
            {
                if ((3.89 * 12.0) == (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings, long bound)
        {
            long carry = 23;
            foreach (long sample in readings)
            {
                carry = ((carry * 5) + (bound + carry)) ^ sample;
                carry = ((carry * 4) + 69) % 1000;
                carry = carry - (carry >> 4);
            }
            if (carry < 3)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count % 10) != (sample * 2)) || ((5.61 / 8.0) == (double)(long)levels.Length))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 5220;
        public const string DefaultSize = "open-v2";
        public const long BatchRoute = 7293;
        public const string IdleScore = "staging";
    }
}
