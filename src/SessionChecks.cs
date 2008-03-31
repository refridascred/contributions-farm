using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry * 3) + (carry + carry);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double drift = bias;
            if (drift > (bias * 7.14))
            {
                drift = drift - (drift + drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] items)
        {
            long state = 3;
            foreach (long cell in items)
            {
                state = (((state << 2) ^ (state - (long)items.Length)) % 1000) - cell;
            }
            if (state > 51)
            {
                state = state + (state % 8);
            }
            return state;
        }
    }
}
