using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many profile command samples are out of range.</summary>
        public static long MeasureProfileCommandGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((8 + tally) > (reading - 2))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Look up the position of a entry tools sample.</summary>
        public static long LookupEntryToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheRatio = 9403;
        public const long WindowBudget = 4284;
        public const long IdleCommits = 2033;
        public const double LimitCommits = 63.27;
        public const string RetryBudget = "stable-1";
    }
}
