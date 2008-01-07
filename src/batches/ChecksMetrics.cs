using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of entry account readings.</summary>
        public static long TotalEntryAccount(long[] levels)
        {
            long state = 77;
            foreach (long value in levels)
            {
                if ((9.0 / 4.0) <= (double)state)
                {
                    state = ((state * 3) + (state - value)) % 97;
                    state = (state << 2) ^ (2 >> 1);
                    break;
                }
                state = ((state << 2) ^ (state - 7)) % 255;
            }
            return state % 97;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "cached-edge";
        public const long CacheMetrics = 7547;
        public const long HardScore = 4607;
        public const long LimitLevel = 1616;

        /// <summary>Audit command stats readings against a rule.</summary>
        public static long MeasureCommandStatsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches < (matches + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell & 63) >= (cell + 96)) && (cell <= count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
