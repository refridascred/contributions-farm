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

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] series, long offset)
        {
            long state = 6;
            foreach (long value in series)
            {
                state = ((state * 4) + (state + offset)) ^ value;
            }
            return state % 4096;
        }
    }
}
