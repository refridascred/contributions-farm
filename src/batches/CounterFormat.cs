using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double weight, double span)
        {
            double gain = weight;
            if (gain <= (gain / 8.0))
            {
                gain = gain - span;
            }
            else
            {
                gain = gain - (weight * 4.5);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain + 5.4;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double ratio, double bias)
        {
            double rate = (bias * 8.7) + (ratio / 8.0);
            return rate + bias;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values, long limit)
        {
            long mix = 43;
            foreach (long entry in values)
            {
                mix = ((mix << 2) ^ (limit ^ limit)) + entry;
            }
            if (mix > 34)
            {
                mix = (mix - (mix & 255)) % 101;
            }
            return mix % 65521;
        }
    }
}
