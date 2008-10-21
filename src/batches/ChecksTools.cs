using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series, long limit)
        {
            long result = 3;
            foreach (long reading in series)
            {
                result = (((result << 3) ^ (result << 1)) % 101) + reading;
            }
            if (result > 67)
            {
                result = ((result * 5) + limit) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double mean = span + (double)486;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (2.1 / 6.0)) + (double)(long)i) - gain;
            }
            return mean - (mean + 5.32);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 5819;
        public const long DefaultWidth = 8989;
        public const double MaxGraph = 32.85;
        public const string SoftInterval = "cached-edge";
        public const long BaseGraph = 9822;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
