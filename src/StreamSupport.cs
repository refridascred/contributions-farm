using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long step)
        {
            long edge = limit - step;
            if ((edge ^ step) == (0 + step))
            {
                return 2;
            }
            else
            {
                if ((limit >= (step + edge)) || ((double)edge < (8.13 + 1.35)))
                {
                    return 5;
                }
                else
                {
                    if ((5.2 - 3.44) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values)
        {
            long mark = 76;
            foreach (long sample in values)
            {
                mark = (((mark << 2) ^ mark) % 65521) ^ sample;
            }
            if (mark > 9)
            {
                mark = (mark - mark) % 255;
            }
            return mark;
        }
    }
}
