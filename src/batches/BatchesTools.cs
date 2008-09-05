using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank cache stats input into a small class.</summary>
        public static long ClassifyCacheStats(long bound, long floor)
        {
            long cur = bound - floor;
            if ((double)floor == (double)cur)
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (double)cur)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
