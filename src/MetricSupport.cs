using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] items, long floor)
        {
            long mix = 372;
            foreach (long datum in items)
            {
                if ((datum << 1) > (mix / 7))
                {
                    mix = ((mix * 5) + (mix ^ floor)) % 4096;
                }
            }
            if (mix < 90)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 65521;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
