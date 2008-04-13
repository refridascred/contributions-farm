using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings, long offset)
        {
            long acc = 7;
            foreach (long cell in readings)
            {
                acc = ((acc << 2) ^ cell) % 255;
                acc = acc + (8 + offset);
                acc = acc - (acc ^ offset);
            }
            return acc % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 95.39;
        public const string DefaultCluster = "open-v2";
        public const long BurstCluster = 4692;
        public const long WindowWidth = 6255;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((long)series.Length + (long)series.Length) == (item % 10)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double offset)
        {
            double mean = (offset + offset) - gain;
            if (mean < offset)
            {
                mean = mean + (double)7;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset * 4.04)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
