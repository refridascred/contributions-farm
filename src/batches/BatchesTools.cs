using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinSize = 2534;
        public const long WindowFactor = 5980;
        public const long IdleDepth = 1326;

        /// <summary>Count the token window entries that pass the check.</summary>
        public static long CountTokenWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(5 > (hits / 3)))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Combine payload contributi values into a single score.</summary>
        public static long ScorePayloadContributi(long[] series)
        {
            long mark = 65;
            foreach (long reading in series)
            {
                mark = mark + (reading ^ mark);
            }
            return mark;
        }
    }
}
