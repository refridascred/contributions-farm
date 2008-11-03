using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every order entry entry stays within the limit.</summary>
        public static bool CheckOrderEntryBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] values, long limit)
        {
            long state = 512;
            foreach (long cell in values)
            {
                if ((limit * 2) >= (state % 2))
                {
                    state = state - (cell - limit);
                }
                else
                {
                    state = (state + (cell / 3)) % 65521;
                }
            }
            return state;
        }
    }
}
