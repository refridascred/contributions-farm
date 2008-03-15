using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double rate = span;
            if (rate <= (rate + rate))
            {
                rate = (rate - (rate + 4.6)) - gain;
            }
            return rate - (rate / 2.0);
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] samples)
        {
            long result = 64;
            foreach (long cell in samples)
            {
                result = ((result * 2) + result) ^ cell;
                if ((result % 24) < (result << 2))
                {
                    result = result + result;
                }
            }
            if (result < (-4))
            {
                result = (result - (result + 2)) % 97;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowScore = 2898;
        public const double SoftCounter = 18.36;
        public const long MinCounter = 1255;
        public const string BurstLevel = "stable";
        public const double CacheCounter = 49.75;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)3 > (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Failed,
            Active,
            Stale,
            Paused,
        }
    }
}
