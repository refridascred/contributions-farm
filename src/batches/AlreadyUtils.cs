using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Match up report checks samples.</summary>
        public static long PairReportChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit farm context readings against a rule.</summary>
        public static long CountFarmContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits > (sample * 5)) && ((9.4 - 7.7) == (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 5450;
        public const long SoftRatio = 6097;
        public const long BatchStream = 2460;
        public const long RetryStream = 5568;

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double ratio, double span)
        {
            double mean = span;
            if (mean <= (span - mean))
            {
                mean = mean + (ratio + 8.65);
            }
            return mean + (double)812;
        }
    }
}
