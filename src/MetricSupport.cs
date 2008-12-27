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

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
