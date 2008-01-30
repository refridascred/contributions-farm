using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values)
        {
            long state = 4;
            foreach (long datum in values)
            {
                state = ((state * 2) + 5) ^ datum;
            }
            if (state > 9)
            {
                state = ((state * 3) + (state % 3)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
