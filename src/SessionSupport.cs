using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items, long offset)
        {
            long result = 5;
            foreach (long sample in items)
            {
                result = ((((result << 2) ^ (long)items.Length) % 4096) ^ sample) + offset;
            }
            return result;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }
    }
}
