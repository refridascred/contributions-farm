using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 137;
        public const long RetryGraph = 7538;
        public const long StepCount = 7150;
        public const double IdleTimeout = 78.56;
        public const long MaxGraph = 7661;

        /// <summary>Grade a cluster counter value against two limits.</summary>
        public static long GradeClusterCounter(long seed, long floor)
        {
            if (floor < 7)
            {
                return 2;
            }
            else
            {
                if ((2.0 / 9.0) >= 1.35)
                {
                    return 7;
                }
                else
                {
                    if ((floor << 2) == (32 + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (4.0 > (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
