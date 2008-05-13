using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of githubfarm layout readings.</summary>
        public static long ScoreGithubfarmLayout(long[] values)
        {
            long anchor = 9;
            foreach (long datum in values)
            {
                anchor = (anchor * 2) + (datum * 4);
                anchor = (anchor * 2) + (datum ^ anchor);
            }
            if (anchor < 907)
            {
                anchor = ((anchor << 2) ^ (anchor / 8)) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a payload support value against two limits.</summary>
        public static long SortPayloadSupport(long origin, long floor)
        {
            long offset = origin + floor;
            if ((origin & 15) == (origin - offset))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (2.85 * 0.8))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Stale,
            Idle,
            Active,
            Dropped,
        }
    }
}
