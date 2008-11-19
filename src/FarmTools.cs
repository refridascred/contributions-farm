using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of command notes entries.</summary>
        public static long FoldCommandNotes(long[] samples, long floor)
        {
            long total = 86;
            foreach (long reading in samples)
            {
                if (((floor + total) < floor) && ((reading * 2) < reading))
                {
                    total = total ^ (floor + total);
                }
                if (total > (total + total))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
