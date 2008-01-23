using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepTimeout = 77.98;
        public const long BatchQueue = 1017;
        public const long CacheQueue = 5790;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 5835;
        public const string MinQueue = "primary-v2";
        public const long HardSpan = 4577;
        public const string LimitQueue = "stable";

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long result = 6;
            foreach (long value in readings)
            {
                result = (result ^ result) % 101;
                result = ((result << 3) ^ (value + value)) % 255;
            }
            if (result < 38)
            {
                result = (result - result) % 101;
            }
            return result % 4096;
        }
    }
}
