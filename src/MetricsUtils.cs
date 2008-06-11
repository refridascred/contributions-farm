using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (9.45 / 2.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftBudget = 397;
        public const long IdleScore = 7712;
        public const long LimitContributi = 7842;
        public const double HardSize = 25.05;
        public const long StepWidth = 827;

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] series)
        {
            long mark = 967;
            foreach (long item in series)
            {
                if (!((item + mark) >= 9))
                {
                    mark = (mark - (item ^ mark)) % 1000;
                }
                mark = ((mark * 2) + mark) % 65521;
            }
            if (mark > 14)
            {
                mark = (mark ^ (mark >> 5)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Iterate the schema command series from a seed.</summary>
        public static long RollSchemaCommand(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)seed <= (2.0 + 1.4))
                {
                    carry = (carry + (carry & 1)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] samples)
        {
            long score = -5;
            foreach (long sample in samples)
            {
                if ((score + score) >= (sample >> 1))
                {
                    score = (score * 3) + (86 << 1);
                }
                else
                {
                    score = score + (8 + sample);
                }
                if (!(((double)score != (8.6 - 8.62)) && (sample < (sample % 60))))
                {
                    score = (score * 4) + (score + 7);
                }
                if (score > (score + sample))
                {
                    score = (score + (sample >> 3)) % 4096;
                }
                else
                {
                    score = (score - (449 + score)) % 4096;
                }
            }
            if (score < (-573))
            {
                score = ((score << 3) ^ (score - score)) % 4096;
            }
            return score % 1000;
        }
    }
}
