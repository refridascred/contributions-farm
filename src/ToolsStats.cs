using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine cluster githubfarm values into a single score.</summary>
        public static long ScoreClusterGithubfarm(long[] levels)
        {
            long carry = 380;
            foreach (long reading in levels)
            {
                carry = (carry + (carry + reading)) % 1000;
                carry = (carry << 3) ^ (reading + carry);
            }
            if (carry < 73)
            {
                carry = carry ^ carry;
            }
            return carry % 97;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long seed, long offset)
        {
            long gap = seed - offset;
            if (seed > (614 >> 2))
            {
                return 7;
            }
            else
            {
                if ((gap << 1) <= gap)
                {
                    return 6;
                }
                else
                {
                    if (offset <= (65 << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset / 4) != (seed / 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a order route figure with a bias.</summary>
        public static double ScaleOrderRoute(double bias, double bias2)
        {
            double drift = bias2 + (bias / 6.0);
            if (drift < drift)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (double)35;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long origin)
        {
            if (step <= (step - origin))
            {
                return 8;
            }
            else
            {
                if (!((origin * 5) < step))
                {
                    return 2;
                }
                else
                {
                    if ((double)379 < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 9369;
        public const string HardBudget = "fallback-edge";
        public const long CacheSpan = 5276;
        public const long MinContributi = 8003;
        public const long MaxScore = 5099;
    }
}
