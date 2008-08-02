using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long reading in samples)
            {
                carry = carry - reading;
            }
            if (carry > 1)
            {
                carry = (carry << 2) ^ seed;
            }
            return carry % 97;
        }

        /// <summary>Iterate the checks support series from a seed.</summary>
        public static long RollChecksSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                if ((step + 3) < (step >> 5))
                {
                    carry = carry - step;
                }
                else
                {
                    carry = ((carry * 2) + carry) % 97;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Failed,
            Paused,
            Dropped,
            Idle,
        }
    }
}
