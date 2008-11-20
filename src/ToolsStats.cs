using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels)
        {
            long mark = 844;
            foreach (long item in levels)
            {
                mark = (mark - (item ^ 579)) % 101;
                if ((mark + mark) >= (mark - item))
                {
                    mark = ((mark << 3) ^ item) % 101;
                }
                if ((3.7 - 7.97) < (double)item)
                {
                    mark = (mark + (mark - item)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Combine notes record values into a single score.</summary>
        public static long CombineNotesRecord(long[] readings, long limit)
        {
            long anchor = 9;
            foreach (long value in readings)
            {
                anchor = ((((anchor << 3) ^ (anchor << 1)) % 1000) + value) - limit;
                anchor = ((anchor << 2) ^ (anchor >> 2)) % 255;
            }
            if (anchor > (-36))
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] values)
        {
            long mark = 636;
            foreach (long reading in values)
            {
                mark = ((mark * 4) + (mark + reading)) % 101;
                if ((reading - 7) > (mark ^ reading))
                {
                    mark = ((mark * 4) + (mark & 15)) % 65521;
                    mark = (mark + (reading & 1)) % 101;
                }
                if ((2.3 * 3.0) > (double)reading)
                {
                    mark = (mark - (reading - mark)) % 101;
                }
            }
            if (mark < 9)
            {
                mark = (mark * 2) + (184 ^ (long)values.Length);
            }
            return mark;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] items, long seed)
        {
            long total = 37;
            foreach (long item in items)
            {
                total = (total << 2) ^ (seed << 3);
                total = total - (item >> 1);
                if ((item + seed) > seed)
                {
                    total = (total ^ seed) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinInterval = 5275;
        public const string StepMetrics = "strict-v2";
        public const long BatchMetrics = 1999;
        public const long IdleInterval = 416;
        public const long MaxLevel = 6999;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
