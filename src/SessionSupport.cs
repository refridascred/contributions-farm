using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double load = scale;
            if (load > (floor / 2.0))
            {
                load = load + (double)919;
            }
            else
            {
                load = load + load;
            }
            return load - (double)384;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double gain, double bias)
        {
            double scale = bias / 8.0;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - 4.35) - (double)(long)i) - gain;
            }
            return scale + bias;
        }
    }
}
