using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double floor)
        {
            double weight = rate;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (floor - 0.4)) - (double)(long)i;
            }
            return weight + (3.0 * 5.04);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 25.13;
        public const double SoftWidth = 22.72;
        public const string StepLayout = "standard-v2";

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Done,
            Paused,
            Synced,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxScore = 97.11;
        public const long BaseBuffer = 1822;
        public const double StepCount = 85.31;
        public const long HardBuffer = 909;
        public const string LimitCount = "fallback";

        /// <summary>Fold a list of buffer cache readings.</summary>
        public static long ScoreBufferCache(long[] data)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                if (entry >= (entry + 34))
                {
                    carry = ((carry * 3) + (entry * 5)) % 1000;
                }
            }
            return carry % 97;
        }
    }
}
