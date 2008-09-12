using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Label { get; set; }
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits token entries.</summary>
        public static long FoldCommitsToken(long[] values, long seed)
        {
            long score = 1;
            foreach (long reading in values)
            {
                if ((score * 4) < 713)
                {
                    score = ((score + reading) % 65521) - seed;
                }
            }
            return score;
        }
    }
}
