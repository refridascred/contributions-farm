using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the token metric series from a seed.</summary>
        public static long IterateTokenMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - (bound + acc)) % 65521;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine command cluster values into a single score.</summary>
        public static long FoldCommandCluster(long[] data)
        {
            long anchor = 879;
            foreach (long cell in data)
            {
                if ((cell + anchor) >= (cell * 4))
                {
                    anchor = (anchor - (95 + anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] series, long step)
        {
            long sum = 9;
            foreach (long item in series)
            {
                sum = ((sum << 3) ^ (item + 9)) + step;
                sum = (sum - (sum % 5)) % 1000;
                if ((item + 2) >= (long)series.Length)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items, long seed)
        {
            long total = 3;
            foreach (long datum in items)
            {
                total = ((total - (42 + 742)) % 1000) - datum;
            }
            if (total < 52)
            {
                total = ((total * 4) + (seed - total)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((2.0 - 1.08) <= (double)matches) || (90 > (matches + matches)))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
