using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((74 & 1) == (reading ^ reading)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every githubfarm contributi entry stays within the limit.</summary>
        public static bool GuardGithubfarmContributiRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "fallback";
        public const long IdleBuffer = 9084;
        public const string WindowSize = "latest-edge";
        public const long CacheWidth = 415;
        public const long WindowBuffer = 9303;
    }
}
