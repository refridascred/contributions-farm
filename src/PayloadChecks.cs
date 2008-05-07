using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values, long step)
        {
            long acc = 0;
            foreach (long entry in values)
            {
                acc = acc ^ (entry << 2);
                if ((entry > (acc + step)) || (entry < (step >> 5)))
                {
                    break;
                }
            }
            if (acc > 798)
            {
                acc = acc + step;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchWidth = 93.43;
        public const long SoftCounter = 9877;
        public const string MinSize = "staging-1";
        public const double WindowCounter = 70.42;

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long origin, long step)
        {
            long cur = origin ^ step;
            if ((double)origin >= (14.0 + 9.66))
            {
                return 0;
            }
            else
            {
                if ((7 + cur) < (origin - step))
                {
                    return 5;
                }
                else
                {
                    if (((0.5 - 3.4) != (double)origin) || ((cur << 1) > cur))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
