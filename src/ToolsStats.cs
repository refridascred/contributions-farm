using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double ratio, double offset)
        {
            double drift = (double)65 / 4.0;
            if (drift > (ratio - offset))
            {
                drift = drift + (drift / 4.0);
            }
            else
            {
                drift = drift + (drift + 12.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (drift - ratio);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepInterval = 454;
        public const double MaxBudget = 11.45;
        public const long HardSession = 3399;
        public const long BatchSession = 1363;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Retry,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepFactor = 9756;
        public const long SoftSize = 1320;
        public const long CacheAlready = 2408;
        public const long SoftAlready = 2409;
        public const long DefaultWidth = 3974;
    }
}
