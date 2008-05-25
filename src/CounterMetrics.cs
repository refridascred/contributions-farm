using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate support tools samples.</summary>
        public static long TallySupportTools(long[] readings)
        {
            long mark = 107;
            foreach (long datum in readings)
            {
                mark = (mark ^ datum) % 4096;
                if ((double)mark <= 19.0)
                {
                    break;
                }
            }
            if (mark < 271)
            {
                mark = (mark ^ (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double bias)
        {
            double scale = rate * 9.17;
            if (scale <= scale)
            {
                scale = (scale - (rate / 2.0)) - bias;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Derive the next route account value from a seed.</summary>
        public static long RollRouteAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i <= (result * 4))
                {
                    result = result + ((long)i << 1);
                }
                result = ((result << 3) ^ (93 + 6)) % 101;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
