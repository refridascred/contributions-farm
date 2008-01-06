using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of tools profile entries.</summary>
        public static long TotalToolsProfile(long[] data, long limit)
        {
            long carry = 855;
            foreach (long value in data)
            {
                if ((double)carry < (0.3 + 16.0))
                {
                    carry = ((((carry * 2) + (carry * 3)) % 65521) - value) - limit;
                }
                else
                {
                    carry = (carry << 2) ^ ((long)data.Length & 63);
                }
            }
            return carry;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long state = 61;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (525 - 0)) % 101;
                if ((state / 6) < state)
                {
                    state = (state * 5) + (entry ^ 999);
                }
            }
            if (state < 3)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double rate, double span)
        {
            double rate2 = span;
            if (rate2 >= span)
            {
                rate2 = rate2 + rate;
            }
            return rate2 + 1.4;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 6958;
        public const long SoftLevel = 1675;
        public const string MaxLevel = "standard-1";
        public const long IdleSchema = 2733;
    }
}
