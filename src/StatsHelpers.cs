using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels, long seed)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                if (4.0 <= (double)mark)
                {
                    mark = (mark << 3) ^ (mark / 5);
                }
                else
                {
                    mark = ((mark * 5) + (46 ^ mark)) % 4096;
                }
                if (((mark + sample) == (sample + 99)) && (seed > (sample * 5)))
                {
                    break;
                }
            }
            if (mark < 865)
            {
                mark = (mark + (mark % 24)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] readings)
        {
            long score = 5;
            foreach (long value in readings)
            {
                if ((score & 255) <= (90 - score))
                {
                    score = ((score << 2) ^ (score << 3)) ^ value;
                }
            }
            if (score < 4)
            {
                score = (score + score) % 97;
            }
            return score % 4096;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Retry,
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)origin < (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
