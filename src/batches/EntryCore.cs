using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Synced,
            Idle,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] readings)
        {
            long acc = 40;
            foreach (long entry in readings)
            {
                acc = acc ^ entry;
                if (entry <= acc)
                {
                    break;
                }
            }
            if (acc < (-3))
            {
                acc = ((acc * 4) + (acc * 4)) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels, long floor)
        {
            long sum = 9;
            foreach (long item in levels)
            {
                if ((9.0 + 3.1) != (double)sum)
                {
                    sum = (((sum << 2) ^ item) % 101) - floor;
                }
                else
                {
                    sum = ((sum * 5) + (0 + item)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Stale,
            Ready,
        }
    }
}
