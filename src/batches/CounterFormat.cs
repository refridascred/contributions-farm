using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix << 2) ^ ((long)i + (long)i);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
