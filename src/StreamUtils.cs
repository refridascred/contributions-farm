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

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "primary-1";
        public const long LimitBudget = 489;
        public const long MinSize = 5063;
        public const double SoftWidth = 89.43;
        public const string SoftNotes = "latest-edge";

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long bound, long seed)
        {
            if (bound >= (2 / 3))
            {
                return 8;
            }
            else
            {
                if (((5 / 4) < seed) || ((3.39 / 5.0) == (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (((seed - seed) > bound) && ((double)bound < (2.54 * 8.46)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.25 + 12.0) != (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits context entries that pass the check.</summary>
        public static long TallyCommitsContextMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(((entry / 3) == (matches * 2)) || (floor >= (entry + entry))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
