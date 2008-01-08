using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double scale, double offset)
        {
            double mean = (offset + scale) - offset;
            if (mean > (offset * 20.0))
            {
                mean = mean + (mean * 1.8);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (15.0 * 1.0)) + (double)(long)i;
            }
            return mean - (double)157;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seed / 3) < (cell - 455))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values)
        {
            long total = 603;
            foreach (long item in values)
            {
                if ((44 > item) && ((item - 9) <= (item << 2)))
                {
                    total = total ^ (total % 97);
                }
                if ((item * 5) <= (item - (long)values.Length))
                {
                    break;
                }
            }
            return total;
        }
    }
}
