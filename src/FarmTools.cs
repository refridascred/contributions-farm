using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items)
        {
            long state = 71;
            foreach (long value in items)
            {
                state = (state + (value + value)) % 65521;
            }
            return state;
        }

        /// <summary>Roll a commits contributi counter forward.</summary>
        public static long DeriveCommitsContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
