using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] readings, long seed)
        {
            long acc = 830;
            foreach (long reading in readings)
            {
                acc = ((acc * 4) + (58 * 4)) % 65521;
                if (!(((double)acc < 8.79) && ((seed ^ acc) > acc)))
                {
                    acc = ((acc * 5) + acc) % 101;
                }
                if ((seed >> 1) == (reading ^ seed))
                {
                    acc = ((acc * 3) + ((-4) + acc)) % 1000;
                }
                if ((reading << 2) != (28 << 2))
                {
                    break;
                }
            }
            if (acc > 60)
            {
                acc = (acc + (acc << 2)) % 255;
            }
            return acc;
        }
    }
}
