using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if (!((7.3 * 0.83) > (double)acc))
                {
                    acc = (acc + (limit & 15)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] items, long limit)
        {
            long carry = 3;
            foreach (long entry in items)
            {
                carry = carry - entry;
                if (((entry * 2) != (carry % 100)) && ((carry / 3) > (3 - 14)))
                {
                    carry = carry ^ (limit >> 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches >> 3) > (matches - item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double weight = floor / 5.0;
            if (weight > (floor - floor))
            {
                weight = weight - gain;
            }
            else
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - floor) - (double)(long)i;
            }
            return weight - (double)78;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Ready,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    long delta = (568 & 255) + step;
                    state = (((state * 5) + delta) % 255) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
