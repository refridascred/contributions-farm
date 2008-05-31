using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the metric account entries that pass the check.</summary>
        public static long MeasureMetricAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally <= reading) && ((267 + reading) >= 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long carry = 521;
            foreach (long reading in samples)
            {
                if (((double)carry >= (9.7 + 15.0)) || ((reading * 4) != (long)samples.Length))
                {
                    carry = (carry ^ 3) % 65521;
                }
                else
                {
                    carry = carry + (reading * 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowSpan = 9403;
        public const long StepRatio = 594;
        public const long BurstFactor = 4579;
        public const long CacheDepth = 1563;
        public const long MaxInterval = 9261;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long sum = 937;
            foreach (long datum in levels)
            {
                sum = (sum + (83 - (-92))) - datum;
            }
            return sum;
        }
    }
}
