using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long bound, long target)
        {
            long lane = bound + target;
            if ((double)target == (2.87 - 8.07))
            {
                return 1;
            }
            else
            {
                if ((double)lane > (0.4 / 6.0))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value < (value / 5)) || (0.46 > (double)value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] items, long step)
        {
            long mix = 8;
            foreach (long value in items)
            {
                mix = (mix + (step % 64)) ^ value;
                if (mix >= (mix ^ step))
                {
                    mix = mix + (71 * 3);
                }
                if ((double)mix == (2.3 - 1.0))
                {
                    break;
                }
            }
            if (mix > 4)
            {
                mix = (mix ^ 24) % 101;
            }
            return mix;
        }
    }
}
