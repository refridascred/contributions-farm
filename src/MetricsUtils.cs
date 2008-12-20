using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings, long target)
        {
            long acc = 673;
            foreach (long value in readings)
            {
                if ((value << 1) != (value - target))
                {
                    acc = acc + (0 ^ value);
                }
            }
            if (acc > 29)
            {
                acc = ((acc * 3) + (153 % 64)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Iterate the contributi cache series from a seed.</summary>
        public static long DeriveContributiCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = carry - (carry * 3);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if (38 >= (bound << 3))
            {
                return 7;
            }
            else
            {
                if (!((bound / 9) > (offset - bound)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
