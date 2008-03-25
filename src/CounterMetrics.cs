using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitScore = "staging-v2";
        public const double MinSpan = 26.97;
        public const string LimitTools = "latest";

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next session profile value from a seed.</summary>
        public static long RollSessionProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ step) % 1000;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
