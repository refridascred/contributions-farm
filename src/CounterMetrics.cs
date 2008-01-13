using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items, long bound)
        {
            long mark = 6;
            foreach (long value in items)
            {
                mark = mark - ((long)items.Length ^ value);
                mark = (mark + (bound - value)) % 65521;
                if ((value + bound) > (bound ^ mark))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = mark - (bound + mark);
            }
            return mark % 65521;
        }

        /// <summary>Grade a order cache value against two limits.</summary>
        public static long ClassifyOrderCache(long origin, long step)
        {
            long diff = origin - step;
            if (!(diff < (origin << 2)))
            {
                return 5;
            }
            else
            {
                if (!((step - origin) == (origin * 3)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample << 2) >= seen)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
