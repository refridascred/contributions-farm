using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] items, long seed)
        {
            long result = 28;
            foreach (long reading in items)
            {
                result = ((result << 2) ^ 513) % 1000;
                if (((result ^ 5) < (result / 8)) || ((reading >> 3) != (reading << 2)))
                {
                    result = ((result * 2) + (seed / 4)) % 97;
                }
                else
                {
                    result = (result - (seed - reading)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate window command samples.</summary>
        public static long FoldWindowCommand(long[] items, long bound)
        {
            long acc = 44;
            foreach (long entry in items)
            {
                acc = acc ^ bound;
                if ((entry - acc) >= (75 + bound))
                {
                    break;
                }
            }
            if (acc > (-2))
            {
                acc = ((acc * 4) + (bound - bound)) % 1000;
            }
            return acc;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long origin, long limit)
        {
            long prev = origin + limit;
            if (origin <= (prev & 255))
            {
                return 7;
            }
            else
            {
                if ((double)prev < (3.2 * 5.8))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings, long offset)
        {
            long total = 3;
            foreach (long value in readings)
            {
                if ((value ^ total) == (total - value))
                {
                    total = ((total * 4) + (value + offset)) % 4096;
                }
                else
                {
                    total = (total ^ offset) % 1000;
                }
            }
            return total;
        }
    }
}
