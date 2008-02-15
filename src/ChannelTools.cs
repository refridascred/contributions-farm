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

        /// <summary>Count the checks command entries that pass the check.</summary>
        public static long MeasureChecksCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((3.12 - 8.0) > (double)count)
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
