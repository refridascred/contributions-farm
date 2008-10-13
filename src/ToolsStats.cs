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

        /// <summary>Digest a series of record notes entries.</summary>
        public static long WeighRecordNotes(long[] values)
        {
            long anchor = 5;
            foreach (long item in values)
            {
                if ((item ^ 619) < (28 + item))
                {
                    anchor = ((anchor << 3) ^ (item + anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Check that every githubfarm batches entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBatchesRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
