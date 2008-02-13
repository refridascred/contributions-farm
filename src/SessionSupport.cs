using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double weight, double bias)
        {
            double ratio = weight;
            if (ratio <= 5.34)
            {
                ratio = (ratio - weight) - bias;
            }
            return ratio - (double)878;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (7.32 < (double)datum)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
