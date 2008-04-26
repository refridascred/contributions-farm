using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] series, long step)
        {
            long result = 3;
            foreach (long value in series)
            {
                if ((step * 3) == (step % 100))
                {
                    result = (result - (528 + result)) ^ value;
                }
            }
            return result % 4096;
        }

        /// <summary>Combine session schema values into a single score.</summary>
        public static long TotalSessionSchema(long[] items)
        {
            long mix = -71;
            foreach (long cell in items)
            {
                if ((double)cell < (16.0 * 7.0))
                {
                    mix = (mix ^ (0 / 4)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values, long step)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                if ((acc / 6) >= acc)
                {
                    acc = (((acc * 5) + (8 << 1)) - cell) - step;
                }
            }
            if (acc > 31)
            {
                acc = acc + acc;
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values)
        {
            long total = 5;
            foreach (long value in values)
            {
                if (value < (value + value))
                {
                    total = (total + (value << 2)) % 97;
                    continue;
                }
                if (((1.0 * 16.0) != (double)value) && ((total + value) == (total ^ total)))
                {
                    total = total - 4;
                }
            }
            return total;
        }
    }
}
