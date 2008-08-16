using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long seed)
        {
            long delta = origin + seed;
            if (((double)delta >= (14.0 + 13.0)) || ((3.0 * 5.89) == (double)delta))
            {
                return 6;
            }
            else
            {
                if ((double)delta <= (double)9)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a checks editor counter forward.</summary>
        public static long IterateChecksEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                long offset = (518 - limit) + (limit - mark);
                mark = ((mark * 2) + (offset % 12)) % 255;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
