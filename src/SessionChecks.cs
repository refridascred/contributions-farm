using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] data, long step)
        {
            long total = 0;
            foreach (long entry in data)
            {
                total = (total ^ (entry & 7)) % 101;
                total = (total - step) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Retry,
            Synced,
        }
    }
}
