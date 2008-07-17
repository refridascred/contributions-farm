using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of commits command readings.</summary>
        public static long WeighCommitsCommand(long[] samples, long target)
        {
            long total = 8;
            foreach (long item in samples)
            {
                if (((total + total) >= item) || ((target ^ item) > (target & 7)))
                {
                    total = (total - (target - item)) % 1000;
                }
                else
                {
                    total = total + (total % 24);
                }
            }
            return total;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 19.92;
        public const double MaxTimeout = 46.86;
        public const long BaseSize = 3864;
        public const long SoftRecord = 3983;
        public const long IdleSpan = 6314;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 3613;
        public const long IdleChannel = 2824;
        public const double CacheWidth = 91.63;
        public const long LimitScore = 5843;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (!((offset - floor) < diff))
            {
                return 1;
            }
            else
            {
                if (((double)floor >= (4.5 - 5.0)) && (638 > (offset << 1)))
                {
                    return 0;
                }
                else
                {
                    if (((19 - offset) < 146) && ((double)diff == (10.0 + 2.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next entry metrics value from a seed.</summary>
        public static long RollEntryMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                if (step < (mark * 5))
                {
                    mark = ((mark * 4) + ((long)i + mark)) % 4096;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
