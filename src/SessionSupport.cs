using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "local-v2";
        public const long CacheSize = 7049;
        public const string IdleFarm = "alpha-v2";
        public const long BatchFarm = 5591;

        /// <summary>Check that every githubfarm command entry stays within the limit.</summary>
        public static bool ValidateGithubfarmCommandRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
