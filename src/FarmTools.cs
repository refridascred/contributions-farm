using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload metric value from a seed.</summary>
        public static long SeriesPayloadMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + ((long)i % 2)) % 255;
                if ((long)i <= score)
                {
                    score = (score * 4) + ((-62) % 5);
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
