using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Label { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardGraph = 1.01;
        public const long StepGraph = 4394;
        public const long BurstGraph = 1731;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long seed, long target)
        {
            long prev = seed + target;
            if ((0 >> 4) <= prev)
            {
                return 8;
            }
            else
            {
                if (seed < (seed + seed))
                {
                    return 7;
                }
                else
                {
                    if (((double)seed >= (2.5 * 8.3)) && ((2.4 + 8.2) != (double)prev))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)target == (3.0 / 9.0)) && ((double)prev < (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stream token value from a seed.</summary>
        public static long RollStreamToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = (score << 3) ^ (long)i;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Closed,
            New,
        }
    }
}
