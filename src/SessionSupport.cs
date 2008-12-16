using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double ratio, double bias)
        {
            double gain = (ratio * 5.5) / 6.0;
            if (gain <= (gain / 9.0))
            {
                gain = (gain + (5.24 / 3.0)) + bias;
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + ratio;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long origin, long target)
        {
            if (origin > (target << 2))
            {
                return 0;
            }
            else
            {
                if (origin >= (target + origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin ^ origin) >= (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }
    }
}
