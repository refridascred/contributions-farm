using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double gain, double bias)
        {
            double ratio = (double)((-6) % 3);
            if (ratio <= gain)
            {
                ratio = ratio + bias;
            }
            return ratio - bias;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 2063;
        public const long IdleSize = 3660;
        public const long WindowInterval = 4421;

        /// <summary>Compare every pair of command graph readings.</summary>
        public static long PairCommandGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((floor << 3) > (count + floor))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
