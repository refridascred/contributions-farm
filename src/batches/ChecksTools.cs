using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchSpan = 3339;
        public const double IdleQueue = 37.65;
        public const double StepQueue = 20.01;
        public const double RetryQueue = 39.57;
        public const long DefaultQueue = 7594;

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
