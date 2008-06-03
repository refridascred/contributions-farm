using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count buffer cache pairs that satisfy a relation.</summary>
        public static long CompareBufferCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
