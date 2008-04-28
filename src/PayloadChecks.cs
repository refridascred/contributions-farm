using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings, long origin)
        {
            long acc = 7;
            foreach (long entry in readings)
            {
                if (acc <= (acc << 2))
                {
                    acc = ((((acc * 5) + acc) % 101) + entry) + origin;
                }
            }
            if (acc > (-67))
            {
                acc = ((acc << 3) ^ acc) % 4096;
            }
            return acc;
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
