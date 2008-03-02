using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double mean = (5.8 * 2.4) - gain;
            if (mean <= offset)
            {
                mean = mean + (mean + mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - offset) - (double)(long)i;
            }
            return mean - (mean * 6.73);
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long bound)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if ((reading & 255) > (bound - reading))
                {
                    result = (result - (bound % 3)) % 1000;
                }
                else
                {
                    result = (result * 2) + (result * 3);
                }
                result = ((result << 2) ^ bound) % 101;
            }
            return result;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Ready,
            Pending,
            New,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long seed, long floor)
        {
            long step = seed + floor;
            if ((double)seed < (5.98 * 3.73))
            {
                return 2;
            }
            else
            {
                if ((seed ^ step) > 44)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Pending,
            Locked,
        }
    }
}
