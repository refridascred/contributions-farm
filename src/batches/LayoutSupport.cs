using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + (limit >> 3)) % 101) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double mean = gain;
            if (mean > span)
            {
                mean = mean - mean;
            }
            return mean - span;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 34.38;
        public const long WindowProfile = 8948;
        public const long WindowSpan = 3308;

        /// <summary>Measure how many farm tools samples are out of range.</summary>
        public static long TallyFarmToolsHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((308 ^ offset) != (offset ^ value)) || ((offset > (value << 2)) && ((double)hits >= 0.1)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings, long bound)
        {
            long result = 30;
            foreach (long value in readings)
            {
                result = (result ^ (bound - result)) + value;
                result = (result * 2) + (bound - bound);
            }
            return result % 1000;
        }
    }
}
