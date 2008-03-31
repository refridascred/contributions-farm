using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] samples, long target)
        {
            long state = 50;
            foreach (long datum in samples)
            {
                state = ((state - (state + target)) % 101) + datum;
            }
            return state;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value < (6.1 + 3.45))
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen & 15) > datum) || ((datum ^ 383) < (datum * 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine editor entry values into a single score.</summary>
        public static long TotalEditorEntry(long[] items, long target)
        {
            long sum = 481;
            foreach (long cell in items)
            {
                sum = (((sum * 3) + target) % 1000) + cell;
            }
            return sum;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long AuditFilterContributiGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((9.42 + 8.1) == (double)tally)
                {
                    tally = ((tally + 2) + sample) + floor;
                }
            }
            return tally;
        }
    }
}
