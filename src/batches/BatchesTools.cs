using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of report batches entries.</summary>
        public static long CombineReportBatches(long[] items, long floor)
        {
            long score = 4;
            foreach (long value in items)
            {
                if ((score << 3) < 44)
                {
                    score = ((score * 3) + (value % 7)) % 255;
                }
                else
                {
                    score = score ^ (floor % 97);
                }
            }
            if (score < 992)
            {
                score = ((score << 3) ^ score) % 65521;
            }
            return score % 97;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] readings)
        {
            long mark = 77;
            foreach (long reading in readings)
            {
                mark = (mark - (mark + mark)) ^ reading;
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ (mark << 3)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 8911;
        public const long MaxSupport = 1249;
        public const long SoftSpan = 3795;
        public const long MaxScore = 1697;
        public const double BurstSpan = 65.96;
    }
}
