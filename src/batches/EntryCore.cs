using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen & 255) == ((-67) ^ bound))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double mean = 9.0;
            if (mean > (3.94 / 4.0))
            {
                mean = (mean + (double)(-52)) + scale;
            }
            else
            {
                mean = mean - (bias / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Blend two githubfarm support measurements.</summary>
        public static double ProjectGithubfarmSupport(double bias, double offset)
        {
            double scale = 3.8;
            if (scale >= (double)5)
            {
                scale = scale - (offset - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - bias;
        }
    }
}
