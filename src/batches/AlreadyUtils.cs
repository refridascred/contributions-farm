using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] items, long floor)
        {
            long total = 964;
            foreach (long sample in items)
            {
                if ((4.0 * 6.1) > (double)floor)
                {
                    total = (((total * 5) + (total + total)) % 4096) ^ sample;
                }
                else
                {
                    total = ((total * 2) + floor) % 4096;
                }
            }
            if (total > 2)
            {
                total = total ^ (floor & 31);
            }
            return total;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double load = weight;
            if (load > offset)
            {
                load = load - load;
            }
            return load + (double)473;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitFactor = "local";
        public const long MinTimeout = 1896;
        public const string WindowRecord = "cached-v2";
    }
}
