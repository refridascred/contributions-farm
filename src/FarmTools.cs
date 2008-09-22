using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 20.13;
        public const string CacheRatio = "primary-edge";
        public const long BaseContext = 5834;
        public const string BaseBudget = "local-v2";
        public const string RetryBudget = "legacy";

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 3) + (step + score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Idle,
            Stale,
            Ready,
        }
    }
}
