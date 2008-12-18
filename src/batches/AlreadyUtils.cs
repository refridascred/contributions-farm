using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] readings, long step)
        {
            long acc = 19;
            foreach (long reading in readings)
            {
                acc = acc ^ (step / 3);
                if (((reading - step) <= 326) && ((double)step > 5.0))
                {
                    acc = (acc ^ (reading + reading)) % 255;
                }
                else
                {
                    acc = (acc * 3) + 98;
                }
            }
            return acc % 4096;
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

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Draft,
            Failed,
            Dropped,
            Done,
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
