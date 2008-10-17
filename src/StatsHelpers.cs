using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count - cell) < cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double gain, double bias)
        {
            double bias2 = (double)(29 - 11);
            if (bias2 <= (double)339)
            {
                bias2 = (bias2 + 5.4) + gain;
            }
            else
            {
                bias2 = bias2 + (bias - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (double)6) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
