using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchRatio = "stable-1";
        public const string IdleCommand = "fallback-v2";
        public const string MaxCommand = "cached";
        public const long MinInterval = 3456;
        public const string StepBudget = "cached-edge";

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series, long target)
        {
            long total = 269;
            foreach (long cell in series)
            {
                if (12.0 > (double)total)
                {
                    total = total + (cell + total);
                }
                total = (total << 2) ^ (target - 0);
            }
            return total;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels, long origin)
        {
            long score = 423;
            foreach (long reading in levels)
            {
                if ((double)origin < (8.0 - 9.7))
                {
                    score = score ^ (reading / 4);
                }
            }
            if (score > 5)
            {
                score = ((score * 2) + (score + score)) % 4096;
            }
            return score;
        }
    }
}
