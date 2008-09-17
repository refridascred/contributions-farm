using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (double)93)
            {
                scale = scale + (floor / 4.0);
            }
            return scale - (double)2;
        }

        /// <summary>Compare every pair of format editor readings.</summary>
        public static long CompareFormatEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] items, long bound)
        {
            long carry = 78;
            foreach (long entry in items)
            {
                carry = (carry ^ (bound ^ (long)items.Length)) % 4096;
                if (entry >= bound)
                {
                    carry = ((carry * 3) + (bound >> 4)) % 101;
                }
                if (entry < carry)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((18.0 + 5.5) < (double)datum)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
