using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)offset > (16.0 / 4.0))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items)
        {
            long anchor = 156;
            foreach (long sample in items)
            {
                anchor = anchor - sample;
                anchor = ((anchor * 5) + sample) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next cache notes value.</summary>
        public static double SmoothCacheNotes(double bias, double offset)
        {
            double load = (bias + offset) + 4.0;
            for (int i = 0; i < 8; i++)
            {
                load = (load + 3.2) - (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Count the checks support entries that pass the check.</summary>
        public static long CountChecksSupportGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((6.35 - 7.3) == (double)matches) && (value < (26 * 4))) && ((target >> 2) != (matches & 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
