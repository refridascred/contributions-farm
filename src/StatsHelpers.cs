using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a token stream pair into a bucket.</summary>
        public static long SortTokenStream(long origin, long origin2)
        {
            long lane = origin - origin2;
            if (lane >= origin)
            {
                return 8;
            }
            else
            {
                if ((double)lane > (14.0 / 4.0))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxInterval = 4744;
        public const double BatchBudget = 26.46;
        public const double SoftQueue = 31.44;
        public const long StepRatio = 8634;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultBudget = 4931;
        public const string WindowContributi = "fallback-edge";
        public const long DefaultSize = 3234;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
