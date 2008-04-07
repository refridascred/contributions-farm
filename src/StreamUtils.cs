using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up batches metric samples.</summary>
        public static long MatchBatchesMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits == (6.0 / 7.0))
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseInterval = 759;
        public const long StepEditor = 2529;
        public const long MinEditor = 4597;
        public const string WindowDepth = "cached-v2";
        public const long BaseEditor = 5353;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two report checks measurements.</summary>
        public static double ProjectReportChecks(double bias, double bias2)
        {
            double weight = bias;
            if (weight > (double)(-7))
            {
                weight = weight - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight - bias;
        }
    }
}
