using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first format checks entry that matches the target.</summary>
        public static long LookupFormatChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                long edge = score;
                score = score - (score + edge);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Stale,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
