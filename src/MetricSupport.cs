using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every command metrics entry stays within the limit.</summary>
        public static bool GuardCommandMetricsRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
