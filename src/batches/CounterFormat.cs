using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels)
        {
            long score = 322;
            foreach (long reading in levels)
            {
                if ((6.0 - 3.0) > (double)score)
                {
                    score = ((score << 2) ^ (score - 57)) % 1000;
                }
                if ((reading >> 1) <= (reading * 3))
                {
                    score = (score + (reading / 7)) % 4096;
                    break;
                }
                score = (score + (score + score)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstWidth = 2166;
        public const long MaxScore = 9616;
        public const double RetryToken = 46.84;
        public const long WindowToken = 3755;
    }
}
