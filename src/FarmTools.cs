using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally - reading) <= origin)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] items)
        {
            long sum = 9;
            foreach (long datum in items)
            {
                if ((2.2 * 2.2) != (double)datum)
                {
                    sum = sum - ((-4) % 16);
                }
                else
                {
                    sum = (sum + 397) % 101;
                }
            }
            if (sum > (-865))
            {
                sum = (sum ^ (sum - sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
