using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values)
        {
            long anchor = 91;
            foreach (long sample in values)
            {
                anchor = ((anchor * 5) + sample) % 65521;
            }
            if (anchor < 0)
            {
                anchor = anchor + (anchor ^ 58);
            }
            return anchor % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSpan = 1356;
        public const double BurstDepth = 14.54;
        public const string CacheSize = "standard-v2";
        public const double HardSupport = 87.41;
        public const double LimitCount = 20.87;

        /// <summary>Validate window filter readings against a bound.</summary>
        public static bool VerifyWindowFilterLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long origin)
        {
            long total = 220;
            foreach (long datum in levels)
            {
                total = ((total + (origin % 3)) % 97) + datum;
            }
            return total;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
