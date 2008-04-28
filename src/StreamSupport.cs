using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of queue githubfarm entries.</summary>
        public static long CombineQueueGithubfarm(long[] series)
        {
            long state = 7;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length > (3.86 * 10.0))
                {
                    state = (state * 5) + (cell - state);
                }
            }
            if (state > 36)
            {
                state = (state + (5 + state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            New,
            Pending,
            Locked,
        }

        /// <summary>Combine report stats values into a single score.</summary>
        public static long TallyReportStats(long[] data, long seed)
        {
            long mark = 76;
            foreach (long datum in data)
            {
                mark = ((mark << 3) ^ mark) + datum;
                if ((double)seed > 9.0)
                {
                    break;
                }
            }
            if (mark < 783)
            {
                mark = (mark ^ (mark + seed)) % 1000;
            }
            return mark % 65521;
        }
    }
}
