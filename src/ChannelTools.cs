using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate format record readings against a bound.</summary>
        public static bool GuardFormatRecordLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
