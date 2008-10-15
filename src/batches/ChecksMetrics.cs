using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long floor, long target)
        {
            long lane = floor - target;
            if (((9.0 + 2.0) <= (double)lane) && ((floor << 2) < (lane + 279)))
            {
                return 1;
            }
            else
            {
                if ((lane << 2) == (lane ^ 5))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + reading) > (reading & 127))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 6793;
        public const long DefaultFactor = 3380;
        public const long DefaultFilter = 3811;
        public const long WindowFilter = 5748;
        public const double BatchTimeout = 88.42;

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Done,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Ready,
            Dropped,
        }
    }
}
