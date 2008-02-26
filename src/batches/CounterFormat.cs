using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] data)
        {
            long sum = -21;
            foreach (long value in data)
            {
                if ((2.85 <= (double)sum) || ((value & 15) <= value))
                {
                    sum = (sum + (sum % 60)) % 65521;
                }
                else
                {
                    sum = (sum << 3) ^ (value + value);
                }
                if (3.8 > (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum - target) != (target / 8))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Draft,
            Stale,
            Idle,
        }
    }
}
