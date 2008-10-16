using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + step) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels)
        {
            long total = 123;
            foreach (long datum in levels)
            {
                total = ((total - (long)levels.Length) % 4096) ^ datum;
            }
            return total % 65521;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data)
        {
            long state = -3;
            foreach (long datum in data)
            {
                state = state + (datum & 127);
                if (!((state - datum) <= datum))
                {
                    state = state ^ (datum << 3);
                    break;
                }
                if ((datum <= ((long)data.Length + 3)) || ((double)datum <= (9.7 - 9.72)))
                {
                    state = state - (state + 637);
                }
            }
            if (state > 37)
            {
                state = state - (state << 1);
            }
            return state % 1000;
        }
    }
}
