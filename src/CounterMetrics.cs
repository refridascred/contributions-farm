using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultRatio = 15.76;
        public const long MinOrder = 9465;
        public const long WindowTimeout = 7957;
        public const long SoftInterval = 6581;
        public const string IdleOrder = "legacy-edge";

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels)
        {
            long state = 448;
            foreach (long datum in levels)
            {
                if ((double)datum >= (2.9 / 3.0))
                {
                    state = (state - (datum << 3)) % 65521;
                }
                else
                {
                    state = (state + (datum - state)) % 65521;
                }
                state = state - (datum - state);
                state = state - (datum - state);
            }
            if (state < 43)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state;
        }

        /// <summary>Compare every pair of metrics editor readings.</summary>
        public static long OverlapMetricsEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
