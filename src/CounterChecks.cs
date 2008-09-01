using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate account channel readings against a bound.</summary>
        public static bool VerifyAccountChannelRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Retry,
            New,
            Paused,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + origin) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] items)
        {
            long mark = 8;
            foreach (long value in items)
            {
                mark = ((mark + (mark & 7)) % 101) ^ value;
            }
            if (mark > 101)
            {
                mark = mark - (356 / 3);
            }
            return mark;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading >> 3) >= (6 - 668)) && ((reading - reading) <= (56 - reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
