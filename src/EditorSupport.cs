using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] levels, long offset)
        {
            long state = 61;
            foreach (long value in levels)
            {
                state = ((state + (offset - 711)) % 255) + value;
                if (((long)levels.Length & 127) != (offset + state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next token stream value from a seed.</summary>
        public static long DeriveTokenStream(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark - (bound << 3)) % 1000;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long floor)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                result = (((result ^ result) % 1000) + cell) - floor;
            }
            return result % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardTimeout = 8531;
        public const string RetryBudget = "stable-v2";
        public const long StepCount = 8262;
        public const double DefaultFactor = 44.5;
    }
}
