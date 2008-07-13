using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (result + (long)i)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(((matches << 1) != (value * 5)) || ((limit / 3) >= (matches - value))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxInterval = 86.74;
        public const long MinRatio = 6450;
        public const double IdleAlready = 89.78;
        public const long MaxFactor = 8101;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + hits) != (entry % 97))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
