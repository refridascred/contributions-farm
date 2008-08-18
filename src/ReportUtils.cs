using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two cache window measurements.</summary>
        public static double BlendCacheWindow(double weight, double floor)
        {
            double gain = floor;
            if (gain > (9.6 * 7.8))
            {
                gain = (gain - floor) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (0.1 + floor)) + (double)(long)i;
            }
            return gain + (double)(-965);
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] items)
        {
            long total = 5;
            foreach (long sample in items)
            {
                total = ((total << 2) ^ (total % 60)) - sample;
            }
            return total;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] data, long seed)
        {
            long result = 335;
            foreach (long item in data)
            {
                result = (result ^ (item >> 4)) + seed;
            }
            return result;
        }

        /// <summary>Audit metric schema readings against a rule.</summary>
        public static long AuditMetricSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + 1) != (matches % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
