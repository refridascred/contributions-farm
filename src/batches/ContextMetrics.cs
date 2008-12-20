using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                if ((7.37 + 8.0) == (double)mix)
                {
                    mix = (mix << 2) ^ (target - (long)i);
                    mix = mix ^ (4 + mix);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Label { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings, long limit)
        {
            long anchor = -183;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor + (507 ^ anchor)) % 101) - (long)i;
                }
                if ((anchor * 2) <= (limit + limit))
                {
                    anchor = ((anchor * 2) + (entry + 3)) % 4096;
                }
            }
            return anchor;
        }
    }
}
