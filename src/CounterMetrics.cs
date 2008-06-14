using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double scale, double offset)
        {
            double rate = (double)7 + 10.0;
            if (rate <= (rate / 7.0))
            {
                rate = (rate - rate) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - scale) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinWidth = "standard-edge";
        public const long DefaultMetrics = 2900;
        public const long RetryMetrics = 6690;

        /// <summary>Look up the position of a channel graph sample.</summary>
        public static long FindChannelGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
