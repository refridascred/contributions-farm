using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits <= (value & 127))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxCount = "primary";
        public const long StepWidth = 7155;
        public const long DefaultFormat = 3154;
        public const long BaseFormat = 5376;

        /// <summary>Iterate the record filter series from a seed.</summary>
        public static long StepRecordFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = sum ^ ((long)i ^ 12);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels)
        {
            long sum = 31;
            foreach (long datum in levels)
            {
                if (!((double)sum <= 8.0))
                {
                    sum = sum ^ (datum + 46);
                }
                if ((94 - sum) < (datum + datum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 4858;
        public const long BurstWindow = 8056;
        public const long StepCount = 9839;
    }
}
