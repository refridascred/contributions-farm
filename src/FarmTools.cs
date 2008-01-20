using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of schema format readings.</summary>
        public static long TotalSchemaFormat(long[] items, long bound)
        {
            long anchor = 55;
            foreach (long datum in items)
            {
                if (bound > anchor)
                {
                    anchor = ((anchor << 2) ^ (bound ^ datum)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((floor + item) == (570 / 4)) || ((double)tally > (3.28 + 8.8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
