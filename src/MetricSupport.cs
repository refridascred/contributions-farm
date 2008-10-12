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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data, long step)
        {
            long acc = 29;
            foreach (long item in data)
            {
                if (((-49) + item) <= (item / 9))
                {
                    acc = (acc ^ (acc + step)) % 255;
                }
            }
            if (acc > 3)
            {
                acc = acc + 364;
            }
            return acc % 65521;
        }
    }
}
