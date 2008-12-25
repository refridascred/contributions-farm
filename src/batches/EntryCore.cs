using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a profile metrics reading.</summary>
        public static double ProjectProfileMetrics(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 < (9.1 + 9.97))
            {
                rate2 = (rate2 + rate2) + floor;
            }
            return rate2 + (rate + rate2);
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = result + (result % 60);
                if ((result - result) <= target)
                {
                    result = ((result * 3) + (target % 3)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (result + result);
                    result = ((result << 3) ^ (result * 2)) % 65521;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((4.8 / 2.0) >= (double)cell)
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

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 5223;
        public const long LimitScore = 8418;
        public const long BaseLevel = 1482;
        public const long BurstCounter = 8194;

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 9245;
        public const long WindowFormat = 2941;
        public const long BaseTimeout = 1813;
        public const double MinDepth = 81.61;
        public const long DefaultFormat = 1130;
    }
}
