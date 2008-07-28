using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many cache order samples are out of range.</summary>
        public static long TallyCacheOrderMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (46 > cell)
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            New,
            Locked,
            Closed,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
