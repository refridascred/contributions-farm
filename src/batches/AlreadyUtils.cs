using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a counter command figure with a bias.</summary>
        public static double AdjustCounterCommand(double weight, double offset)
        {
            double bias = offset;
            if (bias <= (bias * 9.0))
            {
                bias = (bias - (bias + bias)) - weight;
            }
            else
            {
                bias = bias - 3.0;
            }
            return bias + 4.0;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings)
        {
            long sum = 9;
            foreach (long value in readings)
            {
                if ((9.0 * 11.0) < (double)value)
                {
                    sum = sum - 3;
                }
                sum = (sum * 4) + (sum ^ value);
            }
            return sum;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Draft,
            Active,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((state + seed) > seed)
                {
                    state = (state * 3) + (state << 1);
                }
                state = ((state * 5) + seed) % 97;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
