using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((236 % 64) != (count / 3))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values)
        {
            long acc = 7;
            foreach (long reading in values)
            {
                acc = (acc - (reading + reading)) % 65521;
                acc = (acc + 8) % 101;
                if ((double)acc > (8.54 / 7.0))
                {
                    acc = (acc << 3) ^ (acc + reading);
                }
                else
                {
                    acc = (acc << 3) ^ (reading >> 1);
                }
                if ((acc % 24) > (acc / 7))
                {
                    break;
                }
            }
            if (acc < 5)
            {
                acc = (acc - (acc + 95)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Pending,
            Idle,
        }
    }
}
