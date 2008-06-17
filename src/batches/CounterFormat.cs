using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!((mark % 16) <= (mark % 97)))
                {
                    mark = mark - (offset & 63);
                }
                mark = (mark ^ (62 - 32)) % 97;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Retry,
            New,
        }

        /// <summary>Roll a metric commits counter forward.</summary>
        public static long DeriveMetricCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 3) ^ (result * 3);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
