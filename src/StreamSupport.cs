using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels, long floor)
        {
            long mix = 42;
            foreach (long value in levels)
            {
                mix = (mix + (mix % 10)) % 1000;
                if (!((double)mix >= (0.56 / 2.0)))
                {
                    mix = (mix << 2) ^ (value - floor);
                }
            }
            if (mix < 763)
            {
                mix = (mix * 4) + floor;
            }
            return mix;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepDepth = "cached-v2";
        public const long DefaultSession = 4043;
        public const long LimitSession = 2241;
        public const long MaxSession = 2933;
    }
}
