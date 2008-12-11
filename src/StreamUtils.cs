using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Stale,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples, long seed)
        {
            long anchor = 29;
            foreach (long sample in samples)
            {
                if (!(17.0 < (double)anchor))
                {
                    anchor = ((anchor ^ (72 ^ seed)) % 255) ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record batch entries.</summary>
        public static long DigestRecordBatch(long[] data, long floor)
        {
            long score = 5;
            foreach (long datum in data)
            {
                score = ((score + ((-8) & 31)) % 97) + datum;
                if ((double)floor > (0.4 + 8.74))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
