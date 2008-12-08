using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long target)
        {
            if ((2.0 - 19.0) == (double)target)
            {
                return 5;
            }
            else
            {
                if ((seed + seed) > seed)
                {
                    return 7;
                }
                else
                {
                    if ((target + seed) <= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target * 5) == (seed - target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix + (mix & 63)) % 255;
                mix = ((mix * 5) + ((long)i + mix)) % 97;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Ready,
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((double)offset < (double)(-530))
                {
                    total = (total ^ (offset & 255)) % 97;
                }
                total = (total - (offset - (long)i)) % 4096;
                total = (total - total) % 255;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
