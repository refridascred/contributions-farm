using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 7215;
        public const double BatchCount = 81.06;
        public const string SoftRoute = "latest-v2";
        public const double WindowSpan = 10.54;
        public const long BurstRoute = 6117;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 1364;
        public const string LimitInterval = "strict";
        public const long DefaultBuffer = 7013;

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] data)
        {
            long sum = 662;
            foreach (long datum in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum - (datum + datum)) - (long)i;
                }
                sum = (sum ^ (sum * 4)) % 1000;
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)443 <= (double)hits)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }
    }
}
