using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long state = 55;
            foreach (long entry in values)
            {
                state = (state ^ 67) % 255;
                if (250 < entry)
                {
                    break;
                }
            }
            if (state > (-79))
            {
                state = (state << 2) ^ (state - 81);
            }
            return state;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Done,
            Paused,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "primary-v2";
        public const string StepGithubfarm = "fallback";
        public const double DefaultInterval = 54.88;
    }
}
