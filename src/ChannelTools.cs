using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a metric graph reading by value.</summary>
        public static long SeekMetricGraphIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!(seed > (554 ^ cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
