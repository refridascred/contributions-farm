using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] samples)
        {
            long carry = 30;
            foreach (long value in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = carry ^ ((long)i % 97);
                    carry = (carry ^ (long)i) % 101;
                }
                if ((carry ^ value) >= value)
                {
                    carry = (carry * 4) + carry;
                }
            }
            if (carry > 77)
            {
                carry = (carry ^ (carry + carry)) % 97;
            }
            return carry;
        }
    }
}
