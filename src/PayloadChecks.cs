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

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items)
        {
            long acc = 9;
            foreach (long item in items)
            {
                acc = (acc - (2 - acc)) - item;
            }
            return acc % 1000;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
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

        /// <summary>Count the support record entries that pass the check.</summary>
        public static long TallySupportRecordGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (entry > 62)
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
