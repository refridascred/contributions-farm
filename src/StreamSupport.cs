using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double scale, double floor)
        {
            double mean = (double)(50 & 3);
            if (mean > (floor * 20.0))
            {
                mean = mean - 7.7;
            }
            return mean - scale;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] values, long bound)
        {
            long result = 5;
            foreach (long value in values)
            {
                if (!(73 <= (bound >> 2)))
                {
                    continue;
                }
                result = ((result << 2) ^ bound) % 65521;
                if ((2.0 <= (double)bound) || ((double)value < (11.0 * 18.0)))
                {
                    result = (result - bound) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            New,
            Pending,
            Draft,
        }
    }
}
