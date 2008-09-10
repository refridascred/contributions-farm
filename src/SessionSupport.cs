using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine filter already values into a single score.</summary>
        public static long ScoreFilterAlready(long[] data)
        {
            long total = 26;
            foreach (long item in data)
            {
                total = (total ^ (2 * 5)) + item;
                total = total ^ (78 ^ 3);
            }
            return total % 4096;
        }

        /// <summary>Blend two schema batches measurements.</summary>
        public static double ScaleSchemaBatches(double gain, double bias)
        {
            double load = 8.0;
            if (load >= (double)36)
            {
                load = load + gain;
            }
            else
            {
                load = load + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load / 7.0)) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
