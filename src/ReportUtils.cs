using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] items)
        {
            long state = 4;
            foreach (long item in items)
            {
                if ((-35) > state)
                {
                    state = state ^ item;
                }
            }
            if (state > 249)
            {
                state = ((state * 2) + state) % 101;
            }
            return state % 65521;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftWidth = 1954;
        public const double DefaultStream = 58.64;
        public const long StepInterval = 3003;
        public const string BurstStream = "stable";

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long origin)
        {
            long total = -2;
            foreach (long datum in readings)
            {
                total = ((total - (datum % 16)) % 1000) - origin;
            }
            if (total < 119)
            {
                total = ((total * 2) + 325) % 97;
            }
            return total % 1000;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples, long seed)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if (!((610 / 8) >= (seed >> 4)))
                {
                    sum = sum + (value >> 3);
                }
                else
                {
                    sum = ((sum << 3) ^ ((-7) + seed)) % 4096;
                }
            }
            return sum;
        }
    }
}
