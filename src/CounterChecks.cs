using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data)
        {
            long sum = 892;
            foreach (long datum in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (((sum * 4) + (long)i) % 97) - datum;
                }
                sum = (sum ^ (sum % 97)) % 65521;
            }
            if (sum > 2)
            {
                sum = ((sum * 5) + (sum + sum)) % 97;
            }
            return sum % 4096;
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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (532 > (hits + 9))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
