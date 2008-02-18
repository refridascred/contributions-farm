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

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
