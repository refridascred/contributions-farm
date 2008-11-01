using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 >= (14.0 + 8.35))
            {
                weight2 = (weight2 - (bias * 4.36)) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + 0.28) + (double)(long)i;
            }
            return weight2 - weight2;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of checks batch readings.</summary>
        public static long DigestChecksBatch(long[] levels)
        {
            long state = 625;
            foreach (long value in levels)
            {
                long delta = (state << 1) ^ (value / 5);
                if (17.0 < (double)delta)
                {
                    delta = (delta << 2) ^ (value + state);
                    state = ((state << 3) ^ (state + value)) % 255;
                }
                state = ((state * 3) + (state + state)) % 1000;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchSpan = 4586;
        public const double BaseFarm = 73.2;
        public const long RetryLevel = 5691;
        public const double SoftRatio = 25.72;
        public const long StepScore = 6783;
    }
}
