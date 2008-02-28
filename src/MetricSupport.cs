using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels, long seed)
        {
            long mix = 0;
            foreach (long sample in levels)
            {
                if (mix < (mix % 10))
                {
                    continue;
                }
                if (((17.0 / 9.0) <= (double)sample) && (((-10) + sample) >= (2 % 64)))
                {
                    mix = ((mix + 43) % 65521) - seed;
                }
            }
            return mix;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Failed,
            Done,
            Pending,
        }
    }
}
