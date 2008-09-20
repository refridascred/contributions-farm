using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double mean = (double)735 / 9.0;
            if (mean < mean)
            {
                mean = ((mean + (double)71) - ratio) + offset;
            }
            return mean + (double)27;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                sum = sum - (sample << 3);
            }
            return sum;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Locked,
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Combine command filter values into a single score.</summary>
        public static long TallyCommandFilter(long[] items)
        {
            long mark = 3;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (((mark << 2) ^ mark) % 101) + (long)i;
                    mark = mark - (value & 127);
                }
                if (((double)(long)items.Length >= (double)value) && ((mark / 5) != (300 << 3)))
                {
                    mark = (mark * 3) + 137;
                }
                if ((mark % 16) >= mark)
                {
                    mark = (mark ^ mark) % 97;
                }
            }
            if (mark > 0)
            {
                mark = ((mark * 3) + mark) % 255;
            }
            return mark;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen / 8) == ((-696) & 3)) || ((seen + seen) >= seen))
                {
                    seen = ((seen + 3) + item) - target;
                }
            }
            return seen;
        }
    }
}
