using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowRatio = 1091;
        public const double StepLayout = 0.85;
        public const long MinLayout = 4786;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum % 8) > (datum - bound))
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

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseBatch = "strict-edge";
        public const long BaseInterval = 9125;
        public const long HardBatch = 7324;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((8 % 12) <= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((value - value) <= (hits % 60)) && ((double)value >= (4.4 / 7.0))) || (hits <= (value - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data)
        {
            long score = 9;
            foreach (long value in data)
            {
                if (!(((value - value) == (score << 3)) || ((score % 7) >= (score ^ value))))
                {
                    score = score + (score + score);
                }
                if ((value - value) < value)
                {
                    score = ((score * 2) + (score % 8)) % 4096;
                }
            }
            return score;
        }
    }
}
