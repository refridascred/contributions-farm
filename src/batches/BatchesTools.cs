using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] data, long origin)
        {
            long acc = 590;
            foreach (long reading in data)
            {
                acc = ((acc + (acc + (-9))) % 1000) - origin;
                if (acc <= (reading + reading))
                {
                    acc = (acc ^ (acc << 1)) % 65521;
                }
            }
            return acc;
        }
    }
}
