using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Locked,
            Done,
            Idle,
            New,
            Failed,
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((seed - acc) >= (acc << 3))
                {
                    acc = acc + (3 << 1);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
