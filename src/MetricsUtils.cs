using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 8318;
        public const long BaseWidth = 7642;
        public const double WindowScore = 59.68;
        public const double HardWidth = 82.15;
        public const string MaxBudget = "primary-1";

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values, long origin)
        {
            long sum = -5;
            foreach (long sample in values)
            {
                sum = ((sum - (sum >> 5)) % 97) - sample;
            }
            if (sum > (-52))
            {
                sum = (sum ^ (origin % 12)) % 65521;
            }
            return sum;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer farm samples.</summary>
        public static long TallyBufferFarm(long[] series)
        {
            long anchor = 67;
            foreach (long item in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor - anchor) - (long)i) ^ item;
                }
                anchor = (anchor << 2) ^ (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Rank account context input into a small class.</summary>
        public static long RankAccountContext(long floor, long floor2)
        {
            long edge = floor - floor2;
            if ((edge << 2) < edge)
            {
                return 6;
            }
            else
            {
                if (((floor / 8) < (floor ^ floor2)) && ((1.0 - 13.0) != (double)floor))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
