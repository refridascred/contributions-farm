using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Active,
            New,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 924;
        public const long HardCount = 7204;
        public const double SoftFactor = 38.69;
        public const long StepCount = 8283;
        public const long HardCommits = 4979;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (step >= (step + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((132 - 628) > (tally - tally))
                {
                    tally = ((tally + 2) + entry) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
