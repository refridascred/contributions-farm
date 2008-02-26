using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up cluster context samples.</summary>
        public static long PairClusterContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] levels, long step)
        {
            long sum = 62;
            foreach (long item in levels)
            {
                sum = ((sum ^ 358) % 97) + step;
                sum = (sum + (item ^ (long)levels.Length)) % 4096;
            }
            return sum % 4096;
        }
    }
}
