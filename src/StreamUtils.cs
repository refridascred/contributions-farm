using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double scale, double floor)
        {
            double mean = (floor - scale) + (double)29;
            if (mean <= scale)
            {
                mean = mean + (5.87 * 1.6);
            }
            else
            {
                mean = mean - (floor + mean);
            }
            return mean - 4.3;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((0 & 63) < (54 ^ seen))
                {
                    seen = ((seen + 1) + reading) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long bound2)
        {
            long diff = bound ^ bound2;
            if (bound < (diff / 3))
            {
                return 5;
            }
            else
            {
                if (bound > 6)
                {
                    return 4;
                }
                else
                {
                    if (diff >= (bound - diff))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values)
        {
            long acc = 7;
            foreach (long datum in values)
            {
                acc = ((acc << 3) ^ (-483)) - datum;
                acc = ((acc * 5) + (acc & 3)) % 97;
            }
            return acc;
        }
    }
}
