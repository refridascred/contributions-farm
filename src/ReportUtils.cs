using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long limit2)
        {
            long lane = limit ^ limit2;
            if (0.98 <= (double)limit2)
            {
                return 3;
            }
            else
            {
                if ((46 << 2) > (limit2 + limit))
                {
                    return 5;
                }
                else
                {
                    if ((956 + limit) < (limit2 - limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((lane + limit) > (477 / 6)) && ((5.0 - 5.32) > (double)lane))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 8318;
        public const string IdleInterval = "alpha-1";
        public const long IdleProfile = 2848;

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double offset)
        {
            double weight = offset - gain;
            return weight - gain;
        }
    }
}
