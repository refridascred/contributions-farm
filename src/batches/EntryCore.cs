using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series)
        {
            long anchor = -160;
            foreach (long value in series)
            {
                anchor = (anchor + (anchor + anchor)) % 1000;
                if ((anchor ^ anchor) < (anchor >> 4))
                {
                    anchor = (anchor ^ ((long)series.Length + value)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long offset, long target)
        {
            long offset2 = offset ^ target;
            if ((double)offset2 == (10.0 / 8.0))
            {
                return 3;
            }
            else
            {
                if (offset >= (offset % 97))
                {
                    return 5;
                }
                else
                {
                    if (((offset & 1) <= (offset >> 5)) || (((-59) << 2) < (81 - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.8 - 8.32) < (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public long Token { get; set; }
        }
    }
}
