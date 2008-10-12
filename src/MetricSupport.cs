using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long floor)
        {
            if ((double)origin > (2.7 / 2.0))
            {
                return 7;
            }
            else
            {
                if ((364 >= (floor - origin)) && ((double)12 > (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (!(origin > (56 + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings)
        {
            long acc = 583;
            foreach (long entry in readings)
            {
                if ((acc >= (8 % 97)) || ((9 % 100) < (entry - acc)))
                {
                    acc = (acc * 4) + (entry << 3);
                }
            }
            return acc % 4096;
        }
    }
}
