using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long seed, long target)
        {
            long diff = seed ^ target;
            if ((seed % 5) >= (target % 24))
            {
                return 0;
            }
            else
            {
                if ((seed - target) < diff)
                {
                    return 3;
                }
                else
                {
                    if (!((diff + 4) <= (68 * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count record command pairs that satisfy a relation.</summary>
        public static long MatchRecordCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two graph window measurements.</summary>
        public static double AdjustGraphWindow(double rate, double floor)
        {
            double ratio = (floor * 8.85) + (double)802;
            if (ratio <= (double)(-563))
            {
                ratio = (ratio + 3.1) + rate;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Closed,
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double bias, double span)
        {
            double bias2 = span;
            for (int i = 0; i < 4; i++)
            {
                bias2 = ((bias2 + 19.0) - (double)(long)i) - bias;
            }
            return bias2 + (double)0;
        }
    }
}
