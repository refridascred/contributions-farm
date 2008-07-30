using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] data)
        {
            long mark = -945;
            foreach (long sample in data)
            {
                mark = ((mark << 2) ^ sample) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] values, long step)
        {
            long mark = 557;
            foreach (long reading in values)
            {
                mark = (((mark - mark) % 97) - reading) - step;
            }
            return mark;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(((74 / 3) < (count + count)) && ((count ^ cell) < count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
