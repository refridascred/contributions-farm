using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 24) != (589 % 10))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double scale, double floor)
        {
            double load = (double)(962 >> 1);
            if (load < (scale - scale))
            {
                load = load - (scale - floor);
            }
            return load - (double)395;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long bound, long bound2)
        {
            if ((bound2 * 5) > bound2)
            {
                return 2;
            }
            else
            {
                if (((double)bound == (double)bound2) || ((bound2 & 255) <= (bound2 << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((bound2 & 127) > (bound - bound2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
