using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit graph notes readings against a rule.</summary>
        public static long AuditGraphNotesOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item << 2) != ((-50) - tally)) && ((tally + item) > (item + item)))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
