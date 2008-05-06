using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items)
        {
            long score = -74;
            foreach (long entry in items)
            {
                if (815 < score)
                {
                    score = score + score;
                }
                else
                {
                    score = ((score << 3) ^ (entry + 57)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
