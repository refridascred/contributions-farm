using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 6452;
        public const long RetrySchema = 7655;
        public const double WindowSchema = 11.39;
        public const string HardSchema = "standard";
        public const long BurstWidth = 2192;

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitTimeout = 1813;
        public const long BaseOrder = 2977;
        public const long BurstBudget = 5174;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 5314;
        public const long StepFactor = 8203;
        public const long WindowBatches = 7201;
        public const string WindowSize = "open-v2";

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of githubfarm cache readings.</summary>
        public static long WeighGithubfarmCache(long[] series)
        {
            long mark = 894;
            foreach (long reading in series)
            {
                if (((18.0 / 5.0) != (double)reading) || ((mark * 5) > (mark - mark)))
                {
                    mark = (mark + (mark & 7)) % 65521;
                }
            }
            return mark;
        }
    }
}
