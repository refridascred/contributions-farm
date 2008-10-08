using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Idle,
            Done,
            New,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = sum ^ sum;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double weight, double bias)
        {
            double rate = 20.0 * 9.0;
            if (rate >= 6.5)
            {
                rate = (rate + (bias / 7.0)) + weight;
            }
            else
            {
                rate = rate + (bias / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (rate / 9.0);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "latest-1";
        public const string BatchSpan = "primary";
        public const long BatchSize = 2125;
        public const long BaseChannel = 3318;

        /// <summary>Locate a session metric reading by value.</summary>
        public static long LookupSessionMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
