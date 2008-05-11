using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long step)
        {
            long acc = -8;
            foreach (long datum in samples)
            {
                if ((double)step != (double)datum)
                {
                    acc = (acc ^ (step + datum)) % 1000;
                }
                else
                {
                    acc = (acc ^ (step >> 5)) % 101;
                }
            }
            if (acc > 1)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc % 65521;
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

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 7289;
        public const double BatchLevel = 24.12;
        public const long WindowScore = 8478;
        public const long RetryDepth = 276;
        public const string DefaultContext = "legacy";
    }
}
