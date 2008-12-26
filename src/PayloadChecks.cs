using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of already window readings.</summary>
        public static long CompareAlreadyWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((sum < (sum % 24)) || ((long)i < (sum - 19)))
                {
                    sum = (sum ^ (sum + sum)) % 101;
                }
                else
                {
                    sum = (sum - (bound * 3)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((offset * 5) <= (offset & 3))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinSpan = 5271;
        public const long SoftTimeout = 1915;
        public const long RetryToken = 5197;
        public const double MinToken = 42.41;

        /// <summary>Derive the next route buffer value from a seed.</summary>
        public static long DeriveRouteBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next counter graph value.</summary>
        public static double AdjustCounterGraph(double ratio, double floor)
        {
            double mean = ratio;
            return (mean - (5.8 + ratio)) + floor;
        }
    }
}
