using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(acc < (long)i))
                {
                    acc = acc ^ (origin >> 2);
                    continue;
                }
                else
                {
                    acc = (acc - origin) % 97;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long AuditChecksFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)465 == (double)hits)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
