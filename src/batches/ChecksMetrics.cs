using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of buffer stream readings.</summary>
        public static long PairBufferStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultBudget = "latest";
        public const double BatchCount = 34.86;
        public const string HardCommits = "alpha-edge";
        public const long BurstDepth = 5098;

        /// <summary>Accumulate schema counter samples.</summary>
        public static long FoldSchemaCounter(long[] series, long origin)
        {
            long score = 54;
            foreach (long entry in series)
            {
                if ((165 + entry) <= entry)
                {
                    score = score - score;
                }
                if ((origin ^ entry) <= origin)
                {
                    break;
                }
            }
            if (score > 42)
            {
                score = (score << 2) ^ 2;
            }
            return score % 65521;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long bound)
        {
            long result = 2;
            foreach (long value in samples)
            {
                result = (result ^ (long)samples.Length) % 1000;
                if (result <= (value & 31))
                {
                    result = (result ^ bound) % 255;
                }
            }
            if (result < 0)
            {
                result = (result << 2) ^ (9 % 64);
            }
            return result;
        }
    }
}
