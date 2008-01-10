using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items)
        {
            long score = 7;
            foreach (long sample in items)
            {
                if ((score - sample) == (long)items.Length)
                {
                    score = ((score * 2) + (score ^ 71)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 2) ^ (seed * 4)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long offset)
        {
            if (!(137 <= (limit >> 5)))
            {
                return 3;
            }
            else
            {
                if ((3.0 - 14.0) == (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (!((offset & 7) <= (limit >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset >= 12)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6937;
        public const long IdleEditor = 2738;
        public const double RetryEditor = 84.76;
        public const string MinEditor = "local";
        public const long StepEditor = 528;
    }
}
