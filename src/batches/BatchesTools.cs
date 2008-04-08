using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Closed,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] levels, long origin)
        {
            long acc = -273;
            foreach (long sample in levels)
            {
                if ((acc <= (acc >> 3)) || (sample > origin))
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
            }
            if (acc > 39)
            {
                acc = acc + (acc - acc);
            }
            return acc % 97;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
