using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long target, long step)
        {
            if (((target + step) < step) && (step >= (95 / 4)))
            {
                return 5;
            }
            else
            {
                if ((0.17 + 4.6) <= (double)target)
                {
                    return 3;
                }
                else
                {
                    if (((double)step != (6.06 * 11.0)) || ((double)target < (9.9 - 16.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8.08 + 4.4) != (double)target) && ((double)step > (double)target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a checks metrics sample.</summary>
        public static long LookupChecksMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Level { get; set; }
            public double Mode { get; set; }
        }
    }
}
