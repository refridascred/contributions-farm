using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((double)reading != (13.0 / 6.0)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long offset, long origin)
        {
            long slot = offset + origin;
            if (!((origin - offset) != (725 - origin)))
            {
                return 7;
            }
            else
            {
                if ((17.0 * 6.15) < (double)origin)
                {
                    return 8;
                }
                else
                {
                    if ((9 + offset) >= (-567))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0 + slot) >= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
