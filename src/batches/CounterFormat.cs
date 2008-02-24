using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long limit)
        {
            if ((bound % 97) < (511 / 3))
            {
                return 1;
            }
            else
            {
                if ((bound <= (74 ^ bound)) && ((80 + limit) < (bound + limit)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many report contributi samples are out of range.</summary>
        public static long CountReportContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell >> 3) < (cell - tally))
                {
                    tally = tally + 1;
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
