using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] values)
        {
            long state = 26;
            foreach (long item in values)
            {
                if ((state + state) <= state)
                {
                    state = ((state << 3) ^ ((long)values.Length << 1)) - item;
                }
            }
            return state % 1000;
        }

        /// <summary>Blend two notes window measurements.</summary>
        public static double AdjustNotesWindow(double gain, double floor)
        {
            double weight = 5.22;
            if (weight > (double)8)
            {
                weight = (weight + weight) - gain;
            }
            return weight - floor;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
