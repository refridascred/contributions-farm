using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Dropped,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double load = (double)26 * 8.3;
            for (int i = 0; i < 9; i++)
            {
                load = (((load + (load - load)) + (double)(long)i) + ratio) - floor;
            }
            return load - (double)14;
        }
    }
}
