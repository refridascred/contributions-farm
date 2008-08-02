using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many route order samples are out of range.</summary>
        public static long CountRouteOrderOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally ^ sample) > (tally - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank layout stream input into a small class.</summary>
        public static long GradeLayoutStream(long step, long target)
        {
            if ((target + (-99)) > (step % 97))
            {
                return 7;
            }
            else
            {
                if (!((double)target < 18.0))
                {
                    return 3;
                }
                else
                {
                    if (!((double)target > (6.2 + 14.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Done,
            Active,
        }
    }
}
