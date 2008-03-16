using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two stream token measurements.</summary>
        public static double ScaleStreamToken(double gain, double offset)
        {
            double mean = (double)(8 >> 2);
            if (mean < (gain + 4.8))
            {
                mean = mean + (double)421;
            }
            else
            {
                mean = mean - (mean * 3.6);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)1) + (double)(long)i;
            }
            return mean - (mean + offset);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items)
        {
            long result = 478;
            foreach (long value in items)
            {
                if ((double)result >= (8.6 + 1.3))
                {
                    result = result + (value >> 4);
                }
            }
            if (result < 81)
            {
                result = result + (result % 12);
            }
            return result;
        }

        /// <summary>Roll a session commits counter forward.</summary>
        public static long StepSessionCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!((66 * 3) <= (mark % 2)))
                {
                    mark = (mark - ((-50) - mark)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next queue session value.</summary>
        public static double ScaleQueueSession(double gain, double bias)
        {
            double rate = (double)(89 & 255);
            return (rate - (bias + rate)) + gain;
        }
    }
}
