using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Size { get; set; }
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items)
        {
            long acc = 1;
            foreach (long datum in items)
            {
                if ((57 - datum) < 9)
                {
                    acc = (acc ^ (acc + datum)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ (acc + acc);
                }
                if ((datum > (acc + datum)) || ((datum & 1) > datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = state ^ (state + (long)i);
                state = (state - ((-7) % 10)) % 4096;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 90.96;
        public const double StepInterval = 90.65;
        public const double BaseTools = 98.15;
    }
}
