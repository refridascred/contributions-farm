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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Active,
            Done,
            Failed,
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

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long floor, long limit)
        {
            if ((double)893 == (double)limit)
            {
                return 0;
            }
            else
            {
                if ((double)floor < (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((7.81 / 9.0) != (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
