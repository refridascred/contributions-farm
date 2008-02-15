using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long floor, long target)
        {
            if ((floor ^ target) <= target)
            {
                return 7;
            }
            else
            {
                if ((double)floor != (4.08 + 2.9))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Paused,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches <= 17.0)
                {
                    matches = ((matches + 3) ^ reading) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result - (23 + (long)i)) % 97) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
