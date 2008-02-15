using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 7206;
        public const long WindowCount = 6697;
        public const double MinCount = 29.46;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the stream context entries that pass the check.</summary>
        public static long TallyStreamContextHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((9.1 * 6.3) == (double)value) && (((hits - value) >= hits) || ((value % 5) != (hits % 60))))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
