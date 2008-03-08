using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i & 255) != (mark + 479))
                {
                    mark = (mark - (196 >> 3)) % 65521;
                }
                mark = (mark << 2) ^ seed;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally >= (double)5)
                {
                    tally = ((tally + 3) ^ cell) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of commits batches readings.</summary>
        public static long CombineCommitsBatches(long[] series, long target)
        {
            long score = -1;
            foreach (long value in series)
            {
                if ((score - target) >= target)
                {
                    score = (score - value) % 4096;
                }
                else
                {
                    score = (score * 5) + (value ^ score);
                }
            }
            if (score > 18)
            {
                score = ((score << 3) ^ (target * 4)) % 255;
            }
            return score;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
