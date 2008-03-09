using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((step + tally) >= (8 - item)) || ((tally + tally) >= (item & 3))) && !((double)item <= (17.0 + 0.8)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 5205;
        public const long CacheRatio = 1384;
        public const double WindowGithubfarm = 12.95;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!(((long)samples.Length + cell) != (cell >> 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double floor)
        {
            double ratio = 4.0;
            if (ratio >= (3.3 / 2.0))
            {
                ratio = (ratio + weight) - floor;
            }
            else
            {
                ratio = ratio + (ratio - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - 14.0) + (double)(long)i;
            }
            return ratio + weight;
        }
    }
}
