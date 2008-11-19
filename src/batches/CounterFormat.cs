using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((3.39 - 0.6) > (double)matches))
                {
                    matches = ((matches + 1) ^ item) - limit;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long step)
        {
            long result = 78;
            foreach (long reading in series)
            {
                result = ((result + (result * 4)) ^ reading) - step;
            }
            if (result > 859)
            {
                result = result + (result ^ 4);
            }
            return result;
        }
    }
}
