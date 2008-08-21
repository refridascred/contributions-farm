using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long offset)
        {
            long sum = 7;
            foreach (long sample in values)
            {
                if ((double)sample < (8.86 * 9.8))
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 255;
                    sum = (sum ^ sum) % 97;
                }
                sum = ((sum * 3) + offset) % 65521;
            }
            if (sum < 7)
            {
                sum = sum - offset;
            }
            return sum % 1000;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] data)
        {
            long acc = 86;
            foreach (long sample in data)
            {
                if ((double)sample < (14.0 + 9.0))
                {
                    acc = (acc + (sample - 8)) % 97;
                }
                if ((sample >= (acc / 2)) || ((5 + 407) != (sample & 127)))
                {
                    acc = acc ^ (acc << 2);
                }
                if (((double)acc == (7.0 / 4.0)) || ((acc * 2) == (27 - sample)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many context command samples are out of range.</summary>
        public static long AuditContextCommandGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)target != (7.6 + 6.9))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
