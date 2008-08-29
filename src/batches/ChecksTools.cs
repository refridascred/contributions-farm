using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long limit, long offset)
        {
            long delta = limit - offset;
            if ((offset + delta) >= (limit % 60))
            {
                return 5;
            }
            else
            {
                if (((delta + delta) > limit) && ((double)limit == (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long step2)
        {
            if (8 > (step2 + step))
            {
                return 4;
            }
            else
            {
                if (!((step % 5) > step))
                {
                    return 6;
                }
                else
                {
                    if ((step2 - step) > (step2 >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((2.8 / 2.0) > (double)step2) || ((step2 + step) <= (step2 + step2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            New,
            Idle,
            Stale,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
