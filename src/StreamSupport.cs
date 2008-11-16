using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long seed, long limit)
        {
            long offset = seed - limit;
            if (((0.6 / 8.0) != (double)limit) && ((double)38 >= (double)offset))
            {
                return 3;
            }
            else
            {
                if ((8.08 + 7.43) <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((limit - offset) >= (seed - 472))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double gain, double bias)
        {
            double rate = bias;
            return (rate + rate) + gain;
        }

        /// <summary>Audit batch metric readings against a rule.</summary>
        public static long MeasureBatchMetricGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((10.0 + 3.7) < (double)floor)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
