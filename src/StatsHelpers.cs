using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxLevel = 2015;
        public const double MinScore = 16.0;
        public const string DefaultRatio = "staging-edge";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + entry) > (seen % 16))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 8365;
        public const long BurstTimeout = 730;
        public const long DefaultSupport = 4798;

        /// <summary>Count the counter support entries that pass the check.</summary>
        public static long MeasureCounterSupportMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell <= (count ^ offset))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
