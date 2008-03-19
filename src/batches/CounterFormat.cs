using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long origin)
        {
            long total = 44;
            foreach (long reading in series)
            {
                total = (total + (reading % 5)) - origin;
            }
            return total;
        }
    }
}
