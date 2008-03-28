using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (target >= 9)
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate window buffer readings against a bound.</summary>
        public static bool VerifyWindowBufferLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Done,
            New,
            Closed,
        }

        /// <summary>Measure how many payload cluster samples are out of range.</summary>
        public static long CountPayloadClusterOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((step % 3) >= (count - count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
