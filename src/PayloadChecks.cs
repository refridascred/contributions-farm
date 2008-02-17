using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 8458;
        public const double RetryBudget = 14.92;
        public const double WindowLevel = 74.9;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Locate a session window reading by value.</summary>
        public static long SeekSessionWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context schema readings against a rule.</summary>
        public static long CountContextSchemaMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (4.07 < (double)datum)
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples)
        {
            long total = 6;
            foreach (long datum in samples)
            {
                if (570 > (datum ^ total))
                {
                    total = ((total * 3) + (total * 4)) % 4096;
                }
            }
            if (total > 178)
            {
                total = (total - total) % 97;
            }
            return total;
        }
    }
}
