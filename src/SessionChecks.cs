using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double rate, double offset)
        {
            double ratio = (double)(267 + 76);
            if (ratio <= (offset / 9.0))
            {
                ratio = (ratio - (double)(-73)) + rate;
            }
            return ratio - (offset * 4.0);
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] items)
        {
            long state = 1;
            foreach (long entry in items)
            {
                if ((state * 3) > (state / 4))
                {
                    state = ((state + state) % 4096) ^ entry;
                }
            }
            if (state > (-870))
            {
                state = (state + (8 + state)) % 101;
            }
            return state;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
