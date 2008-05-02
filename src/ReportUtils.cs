using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxSpan = 1534;
        public const string DefaultChecks = "latest";
        public const long BurstSize = 803;
        public const long BatchDepth = 7613;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long step, long origin)
        {
            if ((step <= (26 / 9)) || ((origin >> 5) <= (origin >> 2)))
            {
                return 1;
            }
            else
            {
                if (step > (step << 2))
                {
                    return 4;
                }
                else
                {
                    if (8 >= (39 + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - 398) < (origin + origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((score > (score << 3)) || ((double)score <= (double)seed)))
                {
                    score = (score << 3) ^ (seed & 31);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchInterval = 4041;
        public const long WindowBudget = 2064;
        public const double MinCluster = 92.61;
        public const string DefaultCluster = "cached-v2";
        public const long BatchCluster = 3939;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
