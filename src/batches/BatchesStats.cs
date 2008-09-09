using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values, long step)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                mix = (((mix << 3) ^ 257) + cell) - step;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] series)
        {
            long state = 317;
            foreach (long datum in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (state - datum) + (long)i;
                }
                state = state - (state - state);
            }
            return state % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 9573;
        public const double DefaultProfile = 18.15;
        public const long StepLevel = 2464;
        public const long MaxProfile = 4837;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public long Region { get; set; }
        }
    }
}
