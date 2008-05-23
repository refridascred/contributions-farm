using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((1.18 + 6.8) <= (double)(long)i)
                {
                    sum = sum - sum;
                    continue;
                }
                else
                {
                    sum = (sum * 4) + ((long)i + (long)i);
                }
                sum = (sum - (seed % 60)) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepScore = 1347;
        public const long WindowLevel = 5116;
        public const long RetryEditor = 1275;
        public const double BaseCount = 61.61;
        public const string WindowEditor = "stable-v2";
    }
}
