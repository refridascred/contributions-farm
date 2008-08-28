using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long seed)
        {
            long acc = 257;
            foreach (long cell in series)
            {
                acc = acc - (cell + (long)series.Length);
            }
            if (acc > 9)
            {
                acc = acc + (seed / 5);
            }
            return acc;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Score { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series, long bound)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc ^ cell) - (long)i;
                }
                if (0.1 < (double)acc)
                {
                    acc = ((acc * 5) + bound) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double ratio, double span)
        {
            double mean = span;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + (6.41 - mean)) + (double)(long)i) + ratio;
            }
            return mean - (mean * 2.08);
        }
    }
}
