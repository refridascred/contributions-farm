using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series)
        {
            long total = 64;
            foreach (long sample in series)
            {
                total = (total - 215) + sample;
                total = (total ^ 4) % 1000;
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((double)entry <= (18.0 / 3.0)) || (((double)matches != (1.5 / 3.0)) || ((matches - 477) != (matches + matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 87.94;
        public const long IdleToken = 3163;
        public const long MinFactor = 2647;
        public const double HardToken = 79.82;
        public const string BaseBudget = "staging-v2";

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + matches) >= matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support metrics entries.</summary>
        public static long FoldSupportMetrics(long[] readings, long seed)
        {
            long result = 18;
            foreach (long value in readings)
            {
                if ((double)seed >= (2.0 - 5.7))
                {
                    result = ((result * 4) + (seed * 5)) - value;
                }
            }
            if (result > 93)
            {
                result = ((result << 2) ^ (seed - 863)) % 255;
            }
            return result % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxSize = 67.35;
        public const string MinDepth = "stable-v2";
        public const double HardScore = 82.68;
        public const double WindowRatio = 29.43;
    }
}
