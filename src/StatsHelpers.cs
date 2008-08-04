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

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
