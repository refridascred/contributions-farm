using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long state = 74;
            foreach (long cell in data)
            {
                if ((cell + state) > (state - state))
                {
                    state = (state + (state + (long)data.Length)) % 97;
                }
                else
                {
                    state = (state << 3) ^ (state >> 3);
                }
            }
            if (state > 44)
            {
                state = ((state * 4) + state) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Closed,
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally > (reading * 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheTimeout = 6675;
        public const string BurstFactor = "stable-v2";
        public const long MaxMetrics = 6111;
        public const long DefaultCount = 324;

        /// <summary>Count the contributi cluster entries that pass the check.</summary>
        public static long TallyContributiClusterMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count * 4) >= (count + count))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
