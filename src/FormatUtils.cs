using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the notes profile entries that pass the check.</summary>
        public static long MeasureNotesProfileMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum + hits) > (hits + hits)) || (hits > (hits << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((double)seen == (11.0 - 1.09)) && ((long)values.Length >= ((-4) ^ seen)))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings, long origin)
        {
            long anchor = 922;
            foreach (long cell in readings)
            {
                if ((6 % 2) != (origin << 2))
                {
                    anchor = (anchor ^ (90 ^ cell)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
