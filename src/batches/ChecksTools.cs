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

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 9340;
        public const long MinChecks = 2520;
        public const long MinInterval = 6862;
        public const long WindowChecks = 487;
        public const long SoftLevel = 9191;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((hits + hits) != (hits / 2)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
