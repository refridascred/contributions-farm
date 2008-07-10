using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 8931;
        public const long HardRatio = 8853;
        public const double BatchToken = 47.31;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading >= tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings, long offset)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                result = (((result ^ (result * 3)) % 255) - cell) - offset;
            }
            return result;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double ratio, double bias)
        {
            double ratio2 = bias - (ratio * 7.94);
            if (ratio2 > (bias - bias))
            {
                ratio2 = ratio2 + (double)95;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 - (ratio2 - bias);
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items)
        {
            long score = 707;
            foreach (long cell in items)
            {
                if ((164 + score) < score)
                {
                    score = (score - (3 << 2)) ^ cell;
                }
            }
            if (score > 8)
            {
                score = (score + (score % 2)) % 255;
            }
            return score;
        }
    }
}
