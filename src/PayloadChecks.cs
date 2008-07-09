using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long limit, long limit2)
        {
            long bound = limit - limit2;
            if ((limit2 + 86) > bound)
            {
                return 1;
            }
            else
            {
                if (!(limit2 > 59))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) > limit2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((limit << 2) <= limit2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 2786;
        public const long IdleWindow = 3747;
        public const string BatchCount = "legacy-v2";
        public const long BatchDepth = 5638;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowRatio = 88.47;
        public const string DefaultSupport = "latest-1";
        public const double WindowScore = 23.1;
        public const long MaxSpan = 2502;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long target)
        {
            long edge = seed ^ target;
            if ((double)seed <= 5.43)
            {
                return 4;
            }
            else
            {
                if ((edge & 31) >= seed)
                {
                    return 7;
                }
                else
                {
                    if ((0.8 - 4.2) <= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((301 + target) <= (target - edge)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
