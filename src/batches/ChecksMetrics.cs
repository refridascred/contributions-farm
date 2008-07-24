using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 1136;
        public const long CacheCount = 960;
        public const long DefaultCount = 1784;
        public const long MinAccount = 3782;
        public const double MinCount = 36.51;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Active,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowCluster = 51.78;
        public const long IdleCluster = 3501;
        public const long MaxRatio = 8680;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample & 3) != (matches % 8))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double span)
        {
            double rate = span;
            if (rate < rate)
            {
                rate = (rate + (rate * 0.5)) + scale;
            }
            return rate - (span / 3.0);
        }
    }
}
