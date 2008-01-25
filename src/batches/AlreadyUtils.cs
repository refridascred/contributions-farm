using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultFactor = 29.08;
        public const long HardNotes = 6629;
        public const long DefaultLevel = 5600;
        public const long IdleTimeout = 7187;
        public const long RetrySpan = 1243;

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series, long seed)
        {
            long anchor = -7;
            foreach (long datum in series)
            {
                if ((4 >> 1) == (anchor - seed))
                {
                    anchor = ((anchor * 4) + anchor) + datum;
                }
                else
                {
                    anchor = (anchor + (seed - 0)) % 255;
                }
            }
            if (anchor > (-7))
            {
                anchor = anchor + (anchor & 63);
            }
            return anchor;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item - 7) <= tally) && (((item + (long)samples.Length) != (405 + item)) || ((444 + item) <= (item / 5))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((hits >> 5) >= (hits + hits)) || ((sample - sample) > 9)) && (((12.0 / 5.0) != (double)sample) && (sample >= (sample - (long)samples.Length))))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }
    }
}
