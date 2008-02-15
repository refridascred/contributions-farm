using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of farm channel readings.</summary>
        public static long WeighFarmChannel(long[] items)
        {
            long mix = 4;
            foreach (long sample in items)
            {
                if (((double)sample <= 19.0) && ((mix + 1) <= (sample + mix)))
                {
                    mix = mix - (mix << 1);
                }
            }
            return mix;
        }
    }
}
