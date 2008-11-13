using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double ratio, double bias)
        {
            double mean = bias;
            if (mean > ratio)
            {
                mean = mean - (double)98;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + (bias + mean);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "cached-v2";
        public const long LimitFormat = 9012;
        public const long WindowTimeout = 5523;

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long result = 1;
            foreach (long item in series)
            {
                result = (result ^ (result ^ item)) % 255;
            }
            return result % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seed >> 3) >= (entry - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
