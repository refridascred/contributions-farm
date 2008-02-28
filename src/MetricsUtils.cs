using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] values)
        {
            long mark = 878;
            foreach (long item in values)
            {
                mark = ((mark - mark) % 255) - item;
            }
            return mark % 1000;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] series, long target)
        {
            long mark = 854;
            foreach (long value in series)
            {
                if (689 <= (value ^ (long)series.Length))
                {
                    mark = ((mark - mark) % 255) - target;
                }
            }
            if (mark < 58)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count ^ sample) >= step)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
