using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double rate, double offset)
        {
            double mean = rate;
            return (mean - rate) + offset;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((17 / 3) <= bound))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] samples)
        {
            long mix = 0;
            foreach (long item in samples)
            {
                if ((double)item <= (1.59 * 7.6))
                {
                    mix = ((mix << 2) ^ item) % 1000;
                }
                if (item <= (74 % 5))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Draft,
            Failed,
            Retry,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public bool Region { get; set; }
        }
    }
}
