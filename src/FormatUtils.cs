using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine commits order values into a single score.</summary>
        public static long CombineCommitsOrder(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                total = ((total ^ (long)levels.Length) % 65521) ^ reading;
            }
            if (total > (-662))
            {
                total = (total + total) % 97;
            }
            return total % 1000;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double scale, double floor)
        {
            double rate = (0.5 * 1.3) * 4.86;
            if (rate > 8.1)
            {
                rate = (rate + (9.54 * 3.1)) - scale;
            }
            else
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + 17.0) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Locate a record route reading by value.</summary>
        public static long FindRecordRouteIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + sample) < (41 / 6))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
