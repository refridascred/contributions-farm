using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxTimeout = 9307;
        public const long SoftReport = 6560;
        public const long SoftWidth = 862;
        public const string MinReport = "standard-edge";
        public const double SoftSpan = 51.43;

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "local-v2";
        public const double IdleRatio = 45.73;
        public const double BurstRoute = 3.3;
        public const long BatchRoute = 9708;

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 > (bias / 3.0))
            {
                bias2 = (bias2 + 5.25) - rate;
            }
            return bias2 - 18.0;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Combine batch stats values into a single score.</summary>
        public static long ScoreBatchStats(long[] series)
        {
            long acc = 667;
            foreach (long entry in series)
            {
                if ((acc * 2) < (entry + entry))
                {
                    acc = ((acc * 2) + (entry + entry)) % 65521;
                }
            }
            return acc % 1000;
        }
    }
}
