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

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (double)76) + (double)(long)i) - gain;
            }
            return weight - span;
        }

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

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultCount = 84.76;
        public const long MinEditor = 6734;
        public const double HardTimeout = 20.1;
        public const string IdleEditor = "open-v2";
    }
}
