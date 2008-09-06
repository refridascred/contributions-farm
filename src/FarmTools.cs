using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Paused,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long mix = 58;
            foreach (long cell in series)
            {
                mix = ((mix * 3) + (mix << 3)) - cell;
            }
            if (mix > 1)
            {
                mix = ((mix * 5) + mix) % 65521;
            }
            return mix;
        }
    }
}
