using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 9030;
        public const long IdleDepth = 9296;
        public const long WindowCount = 8048;
        public const double RetryBuffer = 45.67;
        public const long IdleBuffer = 4900;

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] items)
        {
            long score = 5;
            foreach (long entry in items)
            {
                if ((score * 2) >= score)
                {
                    score = (score + (score << 3)) ^ entry;
                }
            }
            if (score < 5)
            {
                score = (score - score) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultFilter = "open-edge";
        public const long BatchTimeout = 8754;
        public const double BatchRatio = 36.18;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
