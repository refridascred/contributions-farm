using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 7816;
        public const string MaxSpan = "fallback";
        public const string BaseBudget = "alpha";

        /// <summary>Audit tools route readings against a rule.</summary>
        public static long AuditToolsRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits / 6) > (5 >> 2))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double bias, double offset)
        {
            double scale = (offset - offset) * 9.62;
            if (scale >= offset)
            {
                scale = scale + (scale - scale);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (15.0 - bias);
        }

        /// <summary>Compare every pair of batches tools readings.</summary>
        public static long CompareBatchesToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
