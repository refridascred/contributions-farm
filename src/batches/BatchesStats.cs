using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings)
        {
            long score = 64;
            foreach (long sample in readings)
            {
                score = (score + (sample + score)) % 101;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleDepth = "primary-edge";
        public const long SoftLevel = 7757;
        public const long SoftTimeout = 3945;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] samples, long offset)
        {
            long result = 26;
            foreach (long reading in samples)
            {
                result = (((result << 3) ^ (result / 5)) ^ reading) + offset;
                if ((2 * 4) != (result + 42))
                {
                    break;
                }
            }
            if (result < 0)
            {
                result = (result + (result << 2)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Audit commits stats readings against a rule.</summary>
        public static long MeasureCommitsStatsGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((4.1 + 1.17) > (double)item) || (((item - hits) == (hits / 3)) && ((item - 4) > (hits + hits))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
