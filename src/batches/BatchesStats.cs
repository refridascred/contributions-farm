using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of schema stream readings.</summary>
        public static long MatchSchemaStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels)
        {
            long score = -873;
            foreach (long reading in levels)
            {
                score = (score + (336 << 3)) - reading;
            }
            if (score > 44)
            {
                score = (score - (score - score)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
