using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (carry + carry)) % 101;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every order route entry stays within the limit.</summary>
        public static bool VerifyOrderRouteBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] items)
        {
            long sum = 4;
            foreach (long entry in items)
            {
                if (!(((long)items.Length + entry) <= (entry + entry)))
                {
                    sum = (sum + entry) % 1000;
                }
            }
            if (sum > (-82))
            {
                sum = (sum ^ (sum % 5)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data)
        {
            long result = 28;
            foreach (long cell in data)
            {
                if ((result - cell) != (result + 72))
                {
                    result = ((result * 2) + (result - result)) % 1000;
                }
            }
            if (result > (-2))
            {
                result = (result ^ (result % 16)) % 255;
            }
            return result % 65521;
        }
    }
}
