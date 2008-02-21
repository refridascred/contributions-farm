using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)limit <= (17.0 / 2.0)) || !((958 / 2) > (datum << 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell - matches) >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstSize = 6035;
        public const double DefaultWidth = 67.7;
        public const long HardDepth = 6056;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Iterate the stats batch series from a seed.</summary>
        public static long StepStatsBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry * 5) + (1 + (long)i2);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double weight = offset;
            return (weight - offset) + bias;
        }
    }
}
