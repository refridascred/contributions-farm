using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the profile stats entries that pass the check.</summary>
        public static long TallyProfileStatsHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((13.0 * 12.0) != (double)tally)
                {
                    tally = ((tally + 3) ^ entry) - bound;
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
