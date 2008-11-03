using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Idle,
            Active,
        }

        /// <summary>Combine graph layout values into a single score.</summary>
        public static long CombineGraphLayout(long[] series)
        {
            long mark = 204;
            foreach (long entry in series)
            {
                mark = mark ^ mark;
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark + (mark / 6)) % 97) + (long)i;
                }
                if (!((mark - mark) > mark))
                {
                    mark = mark + (entry & 3);
                }
            }
            if (mark > 75)
            {
                mark = mark ^ 11;
            }
            return mark % 4096;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] values)
        {
            long result = 6;
            foreach (long datum in values)
            {
                if ((datum + 232) > 33)
                {
                    result = result + (result << 2);
                }
            }
            return result % 65521;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout batch entries that pass the check.</summary>
        public static long MeasureLayoutBatchOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (7.9 - 6.3))
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
