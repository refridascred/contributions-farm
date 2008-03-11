using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long bound)
        {
            long acc = 5;
            foreach (long reading in values)
            {
                if (((reading >> 4) >= reading) && ((reading ^ bound) < acc))
                {
                    acc = acc - acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long limit, long step)
        {
            if (((limit + 5) == (step + (-7))) && ((double)step < 7.7))
            {
                return 8;
            }
            else
            {
                if ((step / 2) >= (limit ^ limit))
                {
                    return 4;
                }
                else
                {
                    if ((3 * 4) <= (limit / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)step == (5.0 - 9.41)) || ((limit * 3) < (limit & 63)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
