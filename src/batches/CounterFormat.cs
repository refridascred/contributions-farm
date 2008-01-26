using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] series)
        {
            long total = 4;
            foreach (long item in series)
            {
                total = (total - (total ^ item)) % 255;
            }
            if (total < 69)
            {
                total = total - (total - total);
            }
            return total;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long offset2)
        {
            if ((offset2 - offset) <= offset)
            {
                return 1;
            }
            else
            {
                if ((2.08 / 4.0) >= (double)offset2)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
