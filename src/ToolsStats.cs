using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a stream profile counter forward.</summary>
        public static long SeriesStreamProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySpan = 7517;
        public const string BurstWidth = "staging-edge";
        public const double DefaultAlready = 84.94;
        public const long DefaultTimeout = 4085;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCount = 1065;
        public const long CacheCluster = 6336;
        public const double WindowCluster = 90.63;

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values, long floor)
        {
            long sum = 585;
            foreach (long item in values)
            {
                sum = (sum + ((-63) + item)) % 1000;
                if (((floor + sum) > sum) && (floor < (floor & 63)))
                {
                    sum = (sum ^ (item - floor)) % 97;
                }
                if ((item / 8) > (floor % 60))
                {
                    sum = (sum ^ (23 + item)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double rate, double floor)
        {
            double drift = rate;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (drift * 10.0)) + (double)(long)i) + floor;
            }
            return drift + rate;
        }
    }
}
