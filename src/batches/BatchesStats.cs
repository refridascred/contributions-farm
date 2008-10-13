using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long total = 9;
            foreach (long reading in readings)
            {
                if ((total >= reading) || ((reading + 59) >= reading))
                {
                    total = (total + (total & 31)) % 4096;
                }
            }
            if (total > 8)
            {
                total = total + (total % 24);
            }
            return total;
        }

        /// <summary>Accumulate editor route samples.</summary>
        public static long DigestEditorRoute(long[] levels, long origin)
        {
            long mix = -56;
            foreach (long entry in levels)
            {
                mix = (mix << 2) ^ (mix / 3);
                if ((origin << 2) == (entry * 4))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Failed,
            Done,
            Pending,
            Closed,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
