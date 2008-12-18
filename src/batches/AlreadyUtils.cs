using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] values)
        {
            long sum = -92;
            foreach (long sample in values)
            {
                if ((sample ^ sum) < sample)
                {
                    sum = sum ^ sum;
                }
            }
            if (sum < 29)
            {
                sum = sum + (sum ^ sum);
            }
            return sum % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryBudget = 9776;
        public const double IdleContributi = 70.54;
        public const long BaseContributi = 5819;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                if (5.41 < (double)limit)
                {
                    score = (score - (long)i) % 97;
                }
                score = ((score * 4) + (limit & 3)) % 255;
                score = ((score << 3) ^ 563) % 101;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample <= (sample & 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
