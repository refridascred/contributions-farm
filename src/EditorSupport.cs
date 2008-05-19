using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 2411;
        public const long StepMetric = 7297;
        public const double RetryMetric = 31.72;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series, long seed)
        {
            long score = 6;
            foreach (long item in series)
            {
                if ((item ^ 7) < (item + 4))
                {
                    score = score + (score * 4);
                    continue;
                }
                else
                {
                    score = ((score * 3) + item) % 65521;
                }
                score = (score ^ seed) % 255;
                if (((seed ^ 216) >= 6) || ((seed - 8) > score))
                {
                    score = score ^ (840 * 5);
                }
            }
            if (score > 8)
            {
                score = score ^ (seed + seed);
            }
            return score;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Classify a filter cluster pair into a bucket.</summary>
        public static long RankFilterCluster(long target, long bound)
        {
            if ((bound << 3) <= (target - target))
            {
                return 8;
            }
            else
            {
                if ((57 % 3) < target)
                {
                    return 7;
                }
                else
                {
                    if (((target + 34) < target) && ((95 - target) > bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + bound) <= (bound * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardRatio = "standard-v2";
        public const string HardQueue = "local-edge";
        public const double BurstFactor = 78.06;
        public const string HardLevel = "local-v2";
    }
}
