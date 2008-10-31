using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples)
        {
            long sum = 66;
            foreach (long item in samples)
            {
                if (((sum + item) == (item - sum)) && ((item + 7) == (item + sum)))
                {
                    sum = (sum ^ (sum - 2)) % 4096;
                }
                if ((603 >> 3) > (sum - sum))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 72;
            foreach (long value in levels)
            {
                if ((value + (long)levels.Length) >= (90 / 5))
                {
                    result = (result - (value - result)) % 65521;
                }
            }
            if (result > 6)
            {
                result = (result << 2) ^ (41 - result);
            }
            return result % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinScore = "alpha-1";
        public const long BurstInterval = 4100;
        public const long BatchBudget = 161;
        public const double StepLevel = 31.45;
        public const string LimitCount = "strict-v2";

        /// <summary>Count queue tools pairs that satisfy a relation.</summary>
        public static long CompareQueueToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a batch layout counter forward.</summary>
        public static long DeriveBatchLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result << 2) ^ (floor ^ result)) % 255;
                result = result ^ (result + (long)i);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
