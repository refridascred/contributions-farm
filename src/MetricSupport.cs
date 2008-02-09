using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a support layout value against two limits.</summary>
        public static long ClassifySupportLayout(long seed, long step)
        {
            if ((step & 255) != (55 + step))
            {
                return 8;
            }
            else
            {
                if ((double)step > (double)(-96))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] items)
        {
            long mark = 19;
            foreach (long datum in items)
            {
                if ((20.0 / 8.0) < (double)mark)
                {
                    mark = ((mark << 2) ^ 920) % 101;
                }
                else
                {
                    mark = (mark * 5) + (datum + datum);
                }
            }
            if (mark > 472)
            {
                mark = ((mark << 2) ^ (7 << 3)) % 97;
            }
            return mark;
        }
    }
}
