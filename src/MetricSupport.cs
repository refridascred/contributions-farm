using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            if (!((double)origin <= (6.0 - 19.0)))
            {
                return 3;
            }
            else
            {
                if (((origin + origin) < ((-741) ^ offset)) && ((double)origin != (0.71 / 6.0)))
                {
                    return 1;
                }
                else
                {
                    if ((offset % 12) > (origin >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset / 2) > offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
