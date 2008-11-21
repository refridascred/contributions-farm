using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings)
        {
            long mark = 72;
            foreach (long cell in readings)
            {
                if (((mark - cell) >= (mark / 6)) || ((mark + mark) > (cell * 3)))
                {
                    mark = (mark ^ (mark * 2)) % 65521;
                }
                else
                {
                    mark = mark ^ (mark ^ 89);
                }
                if ((mark + mark) <= (mark + 2))
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a schema route sample.</summary>
        public static long LocateSchemaRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order graph value.</summary>
        public static double AdjustOrderGraph(double gain, double span)
        {
            double weight = 4.8;
            if (weight <= (3.6 * 16.0))
            {
                weight = ((weight + (double)7) + gain) - span;
            }
            return weight - (double)725;
        }
    }
}
