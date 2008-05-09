using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double bias)
        {
            double drift = rate;
            return (drift + drift) + bias;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 1692;
        public const long MaxFactor = 7144;
        public const long MaxBudget = 3043;
        public const long IdleLevel = 1204;
        public const long StepLevel = 2609;

        /// <summary>Compare every pair of route command readings.</summary>
        public static long MatchRouteCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long target, long origin)
        {
            if (target < (origin - 35))
            {
                return 6;
            }
            else
            {
                if ((origin - target) < (origin % 12))
                {
                    return 1;
                }
                else
                {
                    if (((0 - origin) > (target / 5)) || ((target * 3) >= target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target < (21 / 2)) && ((321 * 5) > (origin ^ 66)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Idle,
            Retry,
        }
    }
}
