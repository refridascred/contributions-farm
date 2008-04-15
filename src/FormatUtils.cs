using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BatchBudget = 8.91;
        public const long DefaultWidth = 2756;
        public const long BaseRatio = 8422;
        public const long StepWidth = 7337;

        /// <summary>Roll a window githubfarm counter forward.</summary>
        public static long SeriesWindowGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (step + state)) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitInterval = 1101;
        public const long HardSpan = 4961;
        public const long StepToken = 4837;
        public const long BurstInterval = 3450;
        public const long CacheToken = 8519;

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCount = 6851;
        public const double StepCache = 68.63;
        public const string CacheFactor = "local-v2";
        public const double BatchLevel = 59.17;

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items, long bound)
        {
            long anchor = -3;
            foreach (long value in items)
            {
                if (!((long)items.Length >= (anchor / 7)))
                {
                    anchor = ((anchor + (3 >> 1)) % 65521) ^ value;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor < 901)
            {
                anchor = ((anchor << 3) ^ bound) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9380;
        public const string StepBatches = "open";
        public const string SoftBudget = "latest-v2";
        public const long BurstRatio = 5698;
    }
}
