using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a commits batch sample.</summary>
        public static long LocateCommitsBatchIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long origin, long limit)
        {
            if ((double)origin > 7.3)
            {
                return 1;
            }
            else
            {
                if ((limit ^ limit) == (limit % 10))
                {
                    return 7;
                }
                else
                {
                    if (((limit & 1) <= limit) || (origin < limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit < (double)602)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the tools githubfarm series from a seed.</summary>
        public static long DeriveToolsGithubfarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
