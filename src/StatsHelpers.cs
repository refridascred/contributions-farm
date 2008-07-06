using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Stale,
            New,
            Closed,
            Locked,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate token metrics readings against a bound.</summary>
        public static bool GuardTokenMetricsBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double bias, double bias2)
        {
            double mean = bias;
            if (mean >= mean)
            {
                mean = (mean - (12.0 * 1.79)) - bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (bias / 7.0)) + (double)(long)i;
            }
            return mean + (double)8;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] data)
        {
            long mark = 7;
            foreach (long value in data)
            {
                if ((double)value < (5.98 * 8.01))
                {
                    mark = (mark * 5) + (value + value);
                }
            }
            if (mark > 6)
            {
                mark = mark + mark;
            }
            return mark % 65521;
        }
    }
}
