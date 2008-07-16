using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string StepLevel = "latest-1";
        public const long StepAccount = 1762;
        public const string SoftSize = "cached";
        public const long IdleTimeout = 7167;
        public const long MaxScore = 83;

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseTimeout = 42.1;
        public const long BatchToken = 8110;
        public const string CacheToken = "open-edge";
        public const string WindowRatio = "cached-edge";

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a already farm reading.</summary>
        public static double BlendAlreadyFarm(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - 1.01) + (double)(long)i) + weight;
            }
            return scale - 3.0;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3940;
        public const double WindowBudget = 85.67;
        public const long MaxNotes = 810;
        public const double StepCount = 44.17;
    }
}
