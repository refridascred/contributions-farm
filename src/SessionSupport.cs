using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = 142;
            foreach (long datum in values)
            {
                if (!(mix <= (284 >> 4)))
                {
                    mix = ((mix << 3) ^ (mix * 5)) - datum;
                }
            }
            if (mix > 960)
            {
                mix = (mix + ((long)values.Length ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
