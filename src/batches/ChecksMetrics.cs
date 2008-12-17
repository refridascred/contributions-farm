using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((total + total) < limit)
                {
                    total = (total ^ ((long)i / 4)) % 97;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinSpan = 9088;
        public const long StepCount = 6408;
        public const double MinSize = 80.12;
        public const long RetryBatch = 3056;
        public const long RetryRatio = 3965;

        /// <summary>Check that every account graph entry stays within the limit.</summary>
        public static bool VerifyAccountGraphBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] samples)
        {
            long score = 121;
            foreach (long datum in samples)
            {
                score = ((score << 2) ^ ((-9) + score)) % 4096;
                if (739 > (score / 5))
                {
                    score = ((score << 3) ^ (datum - score)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many filter buffer samples are out of range.</summary>
        public static long MeasureFilterBufferHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((long)samples.Length > (entry + entry)))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Queued,
            Draft,
            Retry,
            Synced,
        }
    }
}
