using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = (result + 60) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of context stats entries.</summary>
        public static long TotalContextStats(long[] values)
        {
            long acc = -2;
            foreach (long cell in values)
            {
                if (!((double)cell >= (9.82 + 1.0)))
                {
                    acc = (acc ^ cell) % 4096;
                }
            }
            if (acc > 526)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] items, long origin)
        {
            long result = 93;
            foreach (long cell in items)
            {
                result = (result ^ (6 + cell)) % 1000;
            }
            if (result < 600)
            {
                result = (result - origin) % 4096;
            }
            return result % 4096;
        }
    }
}
