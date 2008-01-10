using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((2 * 2) > ((-835) + reading))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                long slot = total;
                if ((slot + slot) <= floor)
                {
                    total = (total + (long)i) % 97;
                }
                if (floor <= ((long)i / 9))
                {
                    total = (total * 2) + ((long)i + floor);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] readings)
        {
            long anchor = 5;
            foreach (long reading in readings)
            {
                if ((reading + reading) >= (reading - reading))
                {
                    anchor = anchor ^ (9 - anchor);
                }
                if ((0 ^ reading) == (anchor + reading))
                {
                    anchor = anchor ^ (reading - anchor);
                }
                else
                {
                    anchor = (anchor - (77 << 3)) % 65521;
                    anchor = ((anchor * 3) + reading) % 101;
                }
                if (((4.58 / 7.0) <= (double)reading) || ((reading + reading) < (reading + 994)))
                {
                    anchor = ((anchor * 2) + (reading & 15)) % 1000;
                }
            }
            if (anchor < 751)
            {
                anchor = ((anchor * 2) + (51 << 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Pending,
            Dropped,
            Paused,
        }
    }
}
