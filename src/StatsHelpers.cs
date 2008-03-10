using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry / 6) > seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double weight2 = (weight + weight) * 0.19;
            if (weight2 > offset)
            {
                weight2 = weight2 - (double)79;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (offset - offset)) + (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Count the graph queue entries that pass the check.</summary>
        public static long TallyGraphQueueMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits - hits) > (8 + hits))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Roll a batch already counter forward.</summary>
        public static long IterateBatchAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((96 * 4) <= (origin + origin))
                {
                    state = (state - state) % 65521;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
