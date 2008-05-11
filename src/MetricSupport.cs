using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a metric cache counter forward.</summary>
        public static long StepMetricCache(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!(mix >= floor))
                {
                    mix = ((mix * 4) + floor) % 97;
                    mix = (mix ^ mix) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] items)
        {
            long state = 10;
            foreach (long reading in items)
            {
                state = (state - (long)items.Length) % 1000;
                if ((double)reading < (5.99 * 1.13))
                {
                    state = (state - (state - state)) % 101;
                }
            }
            if (state > 18)
            {
                state = state + 9;
            }
            return state;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Ready,
            Stale,
            Queued,
            Dropped,
        }
    }
}
