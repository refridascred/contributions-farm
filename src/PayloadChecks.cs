using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate format schema readings against a bound.</summary>
        public static bool VerifyFormatSchemaBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = acc + (5 >> 1);
                acc = (acc << 2) ^ (long)i;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Roll a record metrics counter forward.</summary>
        public static long RollRecordMetrics(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (((carry << 2) ^ carry) % 255) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
