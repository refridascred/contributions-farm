using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
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

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long target)
        {
            if ((bound + target) >= target)
            {
                return 7;
            }
            else
            {
                if (!((target + bound) <= bound))
                {
                    return 3;
                }
                else
                {
                    if (((target * 5) != (target + bound)) || ((target * 2) == (target ^ bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
