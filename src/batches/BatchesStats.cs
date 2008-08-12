using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Dropped,
            Ready,
            New,
            Done,
        }

        /// <summary>Count format contributi pairs that satisfy a relation.</summary>
        public static long CompareFormatContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a graph command counter forward.</summary>
        public static long IterateGraphCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i3 = 0; i3 < 3; i3++)
                {
                    mix = (((mix << 3) ^ (481 + mix)) % 4096) - (long)i3;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Retry,
            Ready,
            Locked,
            Done,
        }
    }
}
