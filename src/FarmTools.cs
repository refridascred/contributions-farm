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

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
