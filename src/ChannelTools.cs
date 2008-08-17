using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] data)
        {
            long result = 95;
            foreach (long entry in data)
            {
                if (!((entry % 2) <= 33))
                {
                    result = ((result << 2) ^ (entry + result)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item << 3) < (item + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double gain, double span)
        {
            double load = span - (gain / 9.0);
            return load + 6.97;
        }
    }
}
