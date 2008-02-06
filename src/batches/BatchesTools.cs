using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen << 3) <= seen)
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            New,
            Synced,
            Failed,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
