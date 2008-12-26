using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)item >= 7.5)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] levels, long target)
        {
            long acc = 34;
            foreach (long sample in levels)
            {
                if ((73 % 10) == (acc % 7))
                {
                    acc = acc ^ ((long)levels.Length - sample);
                }
                if ((acc / 2) < (target + target))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long seed)
        {
            long state = 3;
            foreach (long datum in samples)
            {
                if ((((-1) - state) <= state) || (((-7) - state) != (428 % 64)))
                {
                    state = state - (datum - 5);
                }
            }
            if (state < (-648))
            {
                state = state - (seed >> 4);
            }
            return state;
        }
    }
}
