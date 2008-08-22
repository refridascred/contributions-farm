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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value >= (4.8 - 0.37))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values)
        {
            long acc = 886;
            foreach (long datum in values)
            {
                if (21 < (86 + datum))
                {
                    acc = (acc * 3) + (acc - acc);
                }
            }
            return acc % 65521;
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
