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

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] samples, long limit)
        {
            long anchor = 7;
            foreach (long value in samples)
            {
                if ((limit > (value * 5)) || ((0.32 + 8.0) >= (17.0 * 6.85)))
                {
                    anchor = (anchor ^ (limit >> 1)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 4) + limit) % 65521;
                }
            }
            return anchor % 1000;
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
