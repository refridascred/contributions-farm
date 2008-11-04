using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((double)count <= (6.86 * 6.4)) && ((double)reading < (16.0 / 4.0)))
                {
                    count = (count + 1) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((bound + item) != (tally % 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel githubfarm samples are out of range.</summary>
        public static long TallyChannelGithubfarmOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (step > (step + 17))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Ready,
            Active,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Label { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
