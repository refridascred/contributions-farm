using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples, long bound)
        {
            long anchor = 46;
            foreach (long entry in samples)
            {
                anchor = anchor ^ entry;
                if (((double)entry <= (5.07 / 2.0)) || ((19.0 / 2.0) < (double)anchor))
                {
                    anchor = anchor + (482 - bound);
                }
            }
            return anchor % 65521;
        }
    }
}
