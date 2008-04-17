using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2972;
        public const long StepLevel = 3577;
        public const string BatchSize = "alpha-1";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Draft,
            Active,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = state + (long)i2;
                }
                state = state - (state >> 1);
                state = state + state;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double rate = (double)(93 % 5);
            if (rate < rate)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (3.1 - offset)) + (double)(long)i;
            }
            return rate + offset;
        }
    }
}
