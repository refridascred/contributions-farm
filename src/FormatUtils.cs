using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long result = -32;
            foreach (long entry in series)
            {
                result = ((result << 3) ^ (result >> 5)) - entry;
            }
            return result;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Audit stats account readings against a rule.</summary>
        public static long AuditStatsAccountMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((double)datum < (2.66 * 2.8)) || ((-800) <= datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
