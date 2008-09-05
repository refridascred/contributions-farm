using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - offset) % 65521;
                if ((double)(long)i == (7.16 * 6.92))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!(origin >= 953))
                {
                    result = (result << 2) ^ (long)i;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
