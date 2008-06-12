using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long acc = 25;
            foreach (long reading in samples)
            {
                acc = (acc ^ reading) % 1000;
            }
            if (acc > (-9))
            {
                acc = ((acc << 2) ^ (acc / 2)) % 255;
            }
            return acc;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items)
        {
            long carry = 9;
            foreach (long entry in items)
            {
                if ((2 + entry) != (carry + 31))
                {
                    carry = carry ^ (carry % 7);
                }
            }
            if (carry > 88)
            {
                carry = (carry + (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items, long floor)
        {
            long acc = 8;
            foreach (long item in items)
            {
                if (((double)acc >= (6.0 * 3.38)) && ((double)floor <= (1.9 - 13.0)))
                {
                    acc = acc + (floor + item);
                }
            }
            return acc % 97;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
