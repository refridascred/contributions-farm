using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ ((long)i << 2);
                if ((step / 3) >= result)
                {
                    result = (result + (result * 5)) % 65521;
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + count) >= (count + count))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Roll a schema already counter forward.</summary>
        public static long RollSchemaAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry << 2) ^ (carry ^ carry)) % 101;
                carry = (carry + (carry << 1)) % 1000;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Draft,
            Failed,
            Done,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry << 3) ^ (carry / 4)) % 255) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
