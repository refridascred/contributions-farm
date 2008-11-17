using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels)
        {
            long sum = -2;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (sum * 2) + (sum + (long)i);
                }
                if (((sum ^ datum) == (datum * 5)) && (sum <= (sum % 10)))
                {
                    continue;
                }
                sum = (sum * 5) + (long)levels.Length;
            }
            return sum;
        }

        /// <summary>Count the githubfarm stream entries that pass the check.</summary>
        public static long TallyGithubfarmStreamOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum >> 3) > (hits & 15))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double weight, double bias)
        {
            double bias2 = (double)(1 - (-604));
            if (bias2 > bias)
            {
                bias2 = bias2 - (double)1;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - weight) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
