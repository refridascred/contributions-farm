using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                if ((long)items.Length <= 8)
                {
                    anchor = (anchor - (value * 2)) - origin;
                }
            }
            return anchor;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (0.7 >= (double)item)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Size { get; set; } = "";
            public double Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] samples, long offset)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (((mix * 4) + value) % 4096) ^ (long)i;
                }
                mix = (mix ^ (offset + offset)) % 4096;
            }
            return mix;
        }
    }
}
