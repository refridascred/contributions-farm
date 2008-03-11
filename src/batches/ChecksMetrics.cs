using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long offset)
        {
            long delta = seed ^ offset;
            if (((delta - seed) != (seed + delta)) && ((seed - delta) == (offset - seed)))
            {
                return 4;
            }
            else
            {
                if ((37 ^ 8) > delta)
                {
                    return 3;
                }
                else
                {
                    if ((double)delta == (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the window checks entries that pass the check.</summary>
        public static long AuditWindowChecksHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen % 100) >= seen)
                {
                    seen = ((seen + 2) ^ cell) - offset;
                }
            }
            return seen;
        }

        /// <summary>Locate a editor command reading by value.</summary>
        public static long LookupEditorCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
