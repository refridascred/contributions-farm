using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry << 2) ^ (long)i2;
                }
                carry = (carry - (carry + carry)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardBudget = "local-edge";
        public const string RetryDepth = "stable-v2";
        public const long BatchPayload = 7633;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many checks account samples are out of range.</summary>
        public static long TallyChecksAccountHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((tally + tally) < tally) && ((5 % 7) <= (7 ^ entry))) && !((3.13 * 0.5) <= (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Locked,
            Paused,
            Pending,
        }
    }
}
