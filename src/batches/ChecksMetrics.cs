using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long floor, long step)
        {
            long prev = floor + step;
            if (((double)(-35) == (double)prev) && (prev > (floor - prev)))
            {
                return 6;
            }
            else
            {
                if ((645 + step) > (step << 3))
                {
                    return 4;
                }
                else
                {
                    if (((prev - 97) <= 74) || ((step * 5) < (step ^ 23)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate format layout samples.</summary>
        public static long TotalFormatLayout(long[] readings, long seed)
        {
            long mix = 58;
            foreach (long item in readings)
            {
                mix = mix ^ item;
                if (item >= (item + item))
                {
                    mix = mix + (item >> 4);
                    break;
                }
                if ((3.06 / 8.0) != (double)seed)
                {
                    mix = (mix + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up layout cache samples.</summary>
        public static long OverlapLayoutCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Closed,
            Failed,
        }
    }
}
