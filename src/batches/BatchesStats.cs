using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series, long step)
        {
            long score = 924;
            foreach (long sample in series)
            {
                score = (((score << 3) ^ (step ^ step)) % 97) + sample;
                score = score - (score << 3);
            }
            if (score < 2)
            {
                score = (score - 32) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count payload report pairs that satisfy a relation.</summary>
        public static long OverlapPayloadReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
