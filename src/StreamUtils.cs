using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 3121;
        public const string HardBudget = "strict";
        public const double CacheBudget = 50.07;
        public const long HardPayload = 4440;
        public const long SoftPayload = 6456;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double scale = 9.5;
            if (scale >= 16.0)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (weight - scale)) + (double)(long)i;
            }
            return scale + (1.0 + floor);
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings, long floor)
        {
            long result = 1;
            foreach (long sample in readings)
            {
                result = ((result * 2) + floor) ^ sample;
            }
            if (result > 8)
            {
                result = (result + (result - floor)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
