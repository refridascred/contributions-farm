using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)count <= 1.65)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheLevel = "fallback";
        public const long StepCount = 7269;
        public const long MinSpan = 3919;
        public const double MinDepth = 80.87;
        public const double RetryScore = 41.49;

        /// <summary>Derive the next account cache value from a seed.</summary>
        public static long IterateAccountCache(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                if (((double)(-5) <= (double)score) && ((double)floor <= 5.1))
                {
                    score = (score - floor) % 101;
                }
                score = ((score * 3) + (907 - 6)) % 4096;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
