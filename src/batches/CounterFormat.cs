using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate command commits samples.</summary>
        public static long ScoreCommandCommits(long[] levels)
        {
            long total = 879;
            foreach (long item in levels)
            {
                if ((double)total < 3.3)
                {
                    total = ((total << 3) ^ total) - item;
                }
            }
            return total % 65521;
        }
    }
}
