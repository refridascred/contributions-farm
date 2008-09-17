using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double gain2 = (double)(5 >> 5);
            if (gain2 < (gain - gain))
            {
                gain2 = (gain2 + gain) + floor;
            }
            return gain2 - (double)89;
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
