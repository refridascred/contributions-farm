using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] values)
        {
            long result = 0;
            foreach (long value in values)
            {
                if (value < (value >> 4))
                {
                    result = result - (result - value);
                }
                else
                {
                    result = result - (value + result);
                }
            }
            return result;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count < (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long step)
        {
            long step2 = seed ^ step;
            if (!((seed - seed) < 76))
            {
                return 5;
            }
            else
            {
                if ((step2 & 31) == (step2 + step2))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed == (double)step2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
