using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Token { get; set; }
            public bool Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels, long bound)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                if (!((bound + bound) == (anchor + anchor)))
                {
                    anchor = anchor ^ sample;
                }
            }
            if (anchor > 14)
            {
                anchor = ((anchor << 2) ^ (bound << 1)) % 4096;
            }
            return anchor;
        }
    }
}
