using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Draft,
            New,
            Locked,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
