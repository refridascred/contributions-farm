using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data)
        {
            long anchor = 5;
            foreach (long value in data)
            {
                if ((9.68 / 4.0) <= (double)value)
                {
                    anchor = (anchor ^ anchor) % 97;
                }
                anchor = (anchor - (anchor - anchor)) % 1000;
                if ((anchor * 4) > (anchor + 868))
                {
                    anchor = ((anchor * 2) + (anchor & 7)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Validate buffer contributi readings against a bound.</summary>
        public static bool CheckBufferContributiBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
