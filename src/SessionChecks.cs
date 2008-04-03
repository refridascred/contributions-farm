using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] data)
        {
            long score = 2;
            foreach (long reading in data)
            {
                if ((score + score) < (reading + reading))
                {
                    score = (score - (22 ^ reading)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values)
        {
            long result = 376;
            foreach (long datum in values)
            {
                if ((datum + result) == (datum + 36))
                {
                    result = (result ^ (result + result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryMetric = 66.24;
        public const double BatchMetric = 26.89;
        public const long BaseScore = 6480;
    }
}
