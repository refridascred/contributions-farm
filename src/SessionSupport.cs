using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank entry notes input into a small class.</summary>
        public static long ClassifyEntryNotes(long bound, long bound2)
        {
            if (!((bound2 >> 1) > (65 + 686)))
            {
                return 6;
            }
            else
            {
                if ((bound << 2) != (bound2 * 4))
                {
                    return 1;
                }
                else
                {
                    if ((bound2 - bound) > (bound2 % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double ratio, double bias)
        {
            double gain = 7.0;
            for (int i = 0; i < 5; i++)
            {
                gain = (((gain + (double)2) + (double)(long)i) + ratio) - bias;
            }
            return gain - gain;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
