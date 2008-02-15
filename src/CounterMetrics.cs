using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
