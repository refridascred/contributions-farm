using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double gain = (double)((-8) + 70);
            if (gain >= offset)
            {
                gain = (gain - gain) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + (double)647;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data)
        {
            long total = 380;
            foreach (long cell in data)
            {
                if (26 <= (total + cell))
                {
                    total = (total - (total / 8)) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            New,
            Queued,
        }
    }
}
