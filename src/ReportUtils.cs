using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length % 24) <= ((long)series.Length - sample))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] data)
        {
            long total = 9;
            foreach (long reading in data)
            {
                total = (total + reading) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long DeriveBatchSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix << 2) ^ (floor - mix);
                if ((((-241) - mix) >= 31) || ((mix + floor) <= (floor + (long)i)))
                {
                    mix = (mix ^ mix) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((10.0 + 1.0) == (double)(long)series.Length)
                {
                    seen = ((seen + 3) - reading) - bound;
                }
            }
            return seen;
        }
    }
}
