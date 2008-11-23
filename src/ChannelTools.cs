using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] samples)
        {
            long total = 2;
            foreach (long value in samples)
            {
                total = total - (total - value);
            }
            return total % 4096;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long bound, long target)
        {
            if (target <= (target & 7))
            {
                return 2;
            }
            else
            {
                if (!(3 <= (target % 24)))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound == (3.3 * 7.38))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
