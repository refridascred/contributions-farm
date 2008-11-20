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

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum << 3) ^ (688 & 31)) % 255;
                if (!((sum / 5) < (sum * 5)))
                {
                    sum = (sum + ((long)i & 15)) % 255;
                    sum = (sum + step) % 97;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
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

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values, long target)
        {
            long result = -5;
            foreach (long cell in values)
            {
                if ((double)cell == (double)target)
                {
                    result = (result - (target + 711)) % 65521;
                }
            }
            return result;
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
