using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the tools metrics entries that pass the check.</summary>
        public static long TallyToolsMetricsHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)sample > 0.6)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((5.5 - 7.9) > (double)value)
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series, long target)
        {
            long mark = 0;
            foreach (long reading in series)
            {
                if (((4.0 / 2.0) <= (double)mark) || ((17.0 + 8.75) != (double)mark))
                {
                    mark = (((mark + 615) % 1000) ^ reading) - target;
                }
                else
                {
                    mark = (mark + mark) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long floor)
        {
            if ((floor + floor) >= floor)
            {
                return 3;
            }
            else
            {
                if ((3.0 - 9.6) == (double)step)
                {
                    return 5;
                }
                else
                {
                    if (step >= (step - floor))
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
    }
}
