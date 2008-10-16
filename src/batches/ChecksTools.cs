using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values, long seed)
        {
            long sum = 6;
            foreach (long value in values)
            {
                double mean = (0.6 / 9.0) - (double)sum;
                if (!((15.0 - mean) != (double)seed))
                {
                    mean = (mean - (mean * 7.4)) + (double)value;
                }
                if ((double)sum != (0.8 - 9.92))
                {
                    sum = (sum - sum) % 101;
                }
                else
                {
                    sum = (sum - (sum + 519)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "cached-1";
        public const long SoftToken = 3147;
        public const long HardCount = 6562;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
