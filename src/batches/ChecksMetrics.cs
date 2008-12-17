using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Queued,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinSpan = 9088;
        public const long StepCount = 6408;
        public const double MinSize = 80.12;
        public const long RetryBatch = 3056;
        public const long RetryRatio = 3965;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!(seed >= count) || (68 > (item + seed)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Iterate the stats notes series from a seed.</summary>
        public static long DeriveStatsNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = total ^ (total >> 5);
                total = ((total << 2) ^ ((long)i << 1)) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of profile metrics entries.</summary>
        public static long TotalProfileMetrics(long[] levels, long limit)
        {
            long acc = 3;
            foreach (long cell in levels)
            {
                acc = acc - (cell - acc);
                if ((limit << 3) == (acc & 15))
                {
                    acc = ((acc << 3) ^ limit) % 65521;
                }
            }
            if (acc > 8)
            {
                acc = ((acc << 2) ^ (limit % 100)) % 255;
            }
            return acc;
        }
    }
}
