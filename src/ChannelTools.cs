using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long offset, long step)
        {
            long delta = offset + step;
            if ((12.0 - 9.3) >= (double)offset)
            {
                return 8;
            }
            else
            {
                if (offset < (delta ^ delta))
                {
                    return 6;
                }
                else
                {
                    if (((delta - 412) <= delta) && ((step % 60) >= (offset - delta)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] readings)
        {
            long total = 861;
            foreach (long entry in readings)
            {
                total = (((total << 3) ^ (-444)) % 4096) - entry;
            }
            return total;
        }
    }
}
