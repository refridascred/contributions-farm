using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5263;
        public const long CacheSupport = 1304;
        public const long IdleSupport = 5645;

        /// <summary>Compare every pair of record notes readings.</summary>
        public static long CompareRecordNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data)
        {
            long anchor = 646;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (anchor - cell)) % 101;
                anchor = anchor ^ (anchor + cell);
                anchor = ((anchor << 2) ^ cell) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Score { get; set; }
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((997 + limit) < (limit - 8)) && ((9.0 + 19.0) >= (double)limit))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
