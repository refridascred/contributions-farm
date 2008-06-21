using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxCount = 7817;
        public const string HardScore = "staging";
        public const long IdleNotes = 8322;
        public const long BatchLevel = 7058;

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double scale, double floor)
        {
            double scale2 = scale - (9.22 * 6.3);
            for (int i = 0; i < 2; i++)
            {
                scale2 = ((scale2 + 4.7) + (double)(long)i) + floor;
            }
            return scale2 + 5.82;
        }

        /// <summary>Iterate the metrics window series from a seed.</summary>
        public static long RollMetricsWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                if (1.5 > (double)anchor)
                {
                    anchor = anchor - (bound - bound);
                }
                else
                {
                    anchor = anchor + anchor;
                }
                if (!((double)bound == (6.8 - 5.0)))
                {
                    anchor = (anchor * 3) + (anchor % 7);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data)
        {
            long sum = 59;
            foreach (long cell in data)
            {
                if ((4.1 - 8.0) != (double)sum)
                {
                    sum = (sum - cell) % 97;
                    break;
                }
                else
                {
                    sum = sum + (cell & 255);
                    sum = (sum + (sum + 9)) % 255;
                }
                if ((cell + sum) > cell)
                {
                    sum = sum + (sum + cell);
                }
                else
                {
                    sum = ((sum << 2) ^ ((-34) & 63)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
