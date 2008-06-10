using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up stream notes samples.</summary>
        public static long PairStreamNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long score = 0;
            foreach (long datum in items)
            {
                if (!!((double)datum == (double)774))
                {
                    score = ((score << 2) ^ score) % 65521;
                }
                if (((score / 7) < (score / 2)) || ((score * 5) < (478 + datum)))
                {
                    score = (score - score) % 65521;
                }
            }
            if (score < 82)
            {
                score = (score + score) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultCount = 2054;
        public const double HardLevel = 88.28;
        public const long LimitInterval = 4924;
        public const long HardStream = 3040;
        public const long DefaultLevel = 6472;

        /// <summary>Check that every filter support entry stays within the limit.</summary>
        public static bool GuardFilterSupportBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate notes stats readings against a bound.</summary>
        public static bool CheckNotesStatsLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
