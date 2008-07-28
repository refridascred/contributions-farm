using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowRatio = 89.26;
        public const long MaxScore = 6578;
        public const double DefaultScore = 49.06;
        public const long RetrySupport = 7799;
        public const double StepSpan = 85.23;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every session checks entry stays within the limit.</summary>
        public static bool VerifySessionChecksBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next already report value.</summary>
        public static double SmoothAlreadyReport(double ratio, double span)
        {
            double weight = ratio + span;
            if (weight < (weight - weight))
            {
                weight = weight - weight;
            }
            return weight + ratio;
        }
    }
}
