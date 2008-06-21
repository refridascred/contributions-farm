using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long offset, long seed)
        {
            if (!((seed - seed) > (offset & 127)))
            {
                return 7;
            }
            else
            {
                if ((offset - 26) == (offset - offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a counter editor sample.</summary>
        public static long LookupCounterEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor - step) % 97;
                if ((5.25 / 5.0) == (double)anchor)
                {
                    anchor = (anchor ^ (anchor * 5)) % 1000;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
