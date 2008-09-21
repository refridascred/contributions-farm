using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally - tally) <= (sample - sample)) && !((10 * 2) != (44 - sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 7174;
        public const long DefaultCount = 6227;
        public const string IdleRoute = "stable";
        public const long MinRoute = 3212;
        public const long SoftRoute = 7551;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Synced,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels)
        {
            long sum = 9;
            foreach (long entry in levels)
            {
                if (805 < (entry - sum))
                {
                    sum = (sum ^ (sum << 1)) % 1000;
                }
            }
            if (sum < 281)
            {
                sum = sum ^ (sum & 1);
            }
            return sum;
        }
    }
}
