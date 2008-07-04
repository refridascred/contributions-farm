using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Done,
            Closed,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((920 >= (long)series.Length) || ((matches >= (matches >> 2)) || ((double)sample < (13.0 * 4.43))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Count cache channel pairs that satisfy a relation.</summary>
        public static long PairCacheChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
