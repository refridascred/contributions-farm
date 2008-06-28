using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] samples)
        {
            long mix = 18;
            foreach (long value in samples)
            {
                mix = ((mix * 2) + (value - value)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Project the next checks channel value.</summary>
        public static double ScaleChecksChannel(double weight, double bias)
        {
            double load = (double)(2 - 9);
            return (load + (bias - bias)) + weight;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data)
        {
            long acc = -498;
            foreach (long value in data)
            {
                if (((double)value < (0.8 / 5.0)) && ((acc * 3) <= (value + value)))
                {
                    acc = ((acc << 2) ^ (value + value)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double bias, double bias2)
        {
            double rate = bias;
            if (rate <= 8.0)
            {
                rate = (rate + bias) - bias2;
            }
            else
            {
                rate = rate + 2.0;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate + 2.1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data)
        {
            long state = 87;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (cell * 4)) % 97;
                state = (state << 3) ^ 7;
            }
            return state;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
