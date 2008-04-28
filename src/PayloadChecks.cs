using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long sum = 972;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum ^ (item & 1)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 4) + (item + item)) - (long)i2;
                    sum = ((sum * 2) + item) % 101;
                }
                sum = (sum - (69 + item)) % 65521;
            }
            if (sum > 2)
            {
                sum = (sum - (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next route support value from a seed.</summary>
        public static long IterateRouteSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                if (8.9 < (double)(long)i)
                {
                    carry = carry ^ floor;
                }
                if (((floor << 1) <= floor) || ((long)i > carry))
                {
                    carry = (carry - (floor ^ carry)) % 1000;
                    carry = carry - (carry & 15);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (((carry << 3) ^ (carry + carry)) % 255) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long offset, long floor)
        {
            long slot = offset + floor;
            if ((1.9 / 8.0) == (double)offset)
            {
                return 5;
            }
            else
            {
                if ((3.4 - 1.6) <= (double)slot)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count <= (item + item)) || ((double)item >= (5.9 - 4.82)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((double)bound < 1.9) && ((double)total <= (9.06 - 7.06)))
                {
                    total = total ^ ((long)i << 3);
                    break;
                }
                total = (total ^ (total + bound)) % 1000;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
