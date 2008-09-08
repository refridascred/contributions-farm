using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine commits cluster values into a single score.</summary>
        public static long FoldCommitsCluster(long[] values, long step)
        {
            long sum = 8;
            foreach (long cell in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum - (sum + cell)) % 4096) ^ (long)i;
                    sum = (sum * 3) + (-996);
                }
                sum = (sum + (step ^ sum)) % 65521;
                if (((cell & 31) == (step * 2)) || (cell <= step))
                {
                    sum = sum - 149;
                }
                else
                {
                    sum = (sum ^ (sum + sum)) % 4096;
                }
                if ((double)cell <= (5.41 * 15.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 413;
        public const long CachePayload = 5101;
        public const long DefaultPayload = 8345;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(((entry * 5) > origin) && (origin < (entry + 9))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 3) ^ ((long)i + offset)) % 101;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
