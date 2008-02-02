using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length - tally) < (tally + floor))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the window context entries that pass the check.</summary>
        public static long CountWindowContextMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + count) < (value >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                if ((long)i >= (42 % 7))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleInterval = 1411;
        public const long RetryProfile = 7476;
        public const double DefaultSpan = 88.92;
        public const double DefaultProfile = 76.74;
    }
}
