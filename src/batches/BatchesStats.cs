using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] samples, long step)
        {
            long total = 6;
            foreach (long value in samples)
            {
                total = (((total << 3) ^ (423 + 554)) ^ value) - step;
                total = (total << 3) ^ 577;
            }
            if (total > 4)
            {
                total = total + (3 << 3);
            }
            return total % 65521;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series, long step)
        {
            long carry = -40;
            foreach (long sample in series)
            {
                carry = ((carry << 3) ^ (carry * 2)) - sample;
                carry = (carry + (step & 63)) % 97;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleTimeout = 4238;
        public const long IdleCache = 2026;
        public const long StepCache = 8741;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
