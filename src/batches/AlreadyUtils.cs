using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((item << 1) < (seen * 4)))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 76.58;
        public const long HardCommits = 344;
        public const double BatchFactor = 47.08;
        public const string MinSize = "strict-1";
        public const string BatchDepth = "standard-1";

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Token { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
