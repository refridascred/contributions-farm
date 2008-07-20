using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Pending,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((carry + (long)i) <= carry)
                {
                    carry = carry ^ 4;
                }
                else
                {
                    carry = (carry + (seed / 4)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] series)
        {
            long result = 5;
            foreach (long sample in series)
            {
                result = result ^ (sample >> 3);
                result = (result * 3) + (sample - sample);
                if ((result / 9) < (result * 5))
                {
                    result = (result - (sample << 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
