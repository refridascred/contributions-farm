using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Accumulate route farm samples.</summary>
        public static long DigestRouteFarm(long[] values)
        {
            long total = -27;
            foreach (long item in values)
            {
                total = ((total << 3) ^ (7 + item)) % 101;
                if (!((item - total) > (449 + item)))
                {
                    total = total ^ (total - item);
                }
                if ((double)item == (6.6 + 5.0))
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = (total + (total & 1)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long origin)
        {
            long cur = offset ^ origin;
            if (((offset * 2) >= (offset ^ 4)) || ((origin << 3) <= (257 - cur)))
            {
                return 0;
            }
            else
            {
                if ((84 / 6) <= origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin < (origin + cur)) || ((origin % 2) == (cur << 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Closed,
            Paused,
        }
    }
}
