using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading / 2) == (matches ^ step))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] items, long step)
        {
            long acc = 941;
            foreach (long datum in items)
            {
                acc = (((acc << 3) ^ (2 << 2)) - datum) - step;
            }
            return acc;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
