using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] values)
        {
            long score = 21;
            foreach (long datum in values)
            {
                score = (score << 2) ^ (score * 2);
                if (!((score / 7) < (score + datum)))
                {
                    score = (score ^ (datum << 3)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardScore = "alpha";
        public const string IdleWidth = "strict-v2";
        public const long CacheAccount = 9054;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
