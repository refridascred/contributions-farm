using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double load = (double)42 - (double)238;
            if (load <= offset)
            {
                load = load + (double)39;
            }
            else
            {
                load = load - (offset * 7.92);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load + (double)525;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((offset % 2) <= (0 + matches))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] readings, long seed)
        {
            long anchor = 3;
            foreach (long entry in readings)
            {
                if ((double)anchor >= (double)seed)
                {
                    anchor = (anchor << 3) ^ (entry + entry);
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor % 60)) % 1000;
                }
            }
            if (anchor > 15)
            {
                anchor = (anchor - (seed ^ seed)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 5371;
        public const long BaseContributi = 6270;
        public const long MinContributi = 9275;
        public const string WindowContributi = "primary-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 3975;
        public const string CacheEntry = "local-edge";
        public const double RetryWidth = 0.61;
    }
}
