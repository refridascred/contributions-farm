using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a checks cache value against two limits.</summary>
        public static long SortChecksCache(long step, long step2)
        {
            long lane = step ^ step2;
            if (((5 & 3) <= step2) && ((lane - step) <= (step - step2)))
            {
                return 2;
            }
            else
            {
                if ((double)step <= (7.0 * 8.62))
                {
                    return 8;
                }
                else
                {
                    if (((double)step > 4.22) && ((163 << 1) == (step & 63)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] levels, long seed)
        {
            long score = 93;
            foreach (long cell in levels)
            {
                if (745 > cell)
                {
                    score = ((score << 2) ^ cell) % 1000;
                    score = score ^ (cell ^ cell);
                }
                score = score - 40;
            }
            if (score < (-65))
            {
                score = ((score * 4) + seed) % 65521;
            }
            return score % 97;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the batches route entries that pass the check.</summary>
        public static long CountBatchesRouteHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally > (item * 2)) && (tally < (bound << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
        }
    }
}
