using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long seed, long offset)
        {
            long delta = seed + offset;
            if (((seed << 1) <= 9) && (44 >= seed))
            {
                return 8;
            }
            else
            {
                if ((seed >> 2) < (seed * 2))
                {
                    return 2;
                }
                else
                {
                    if ((20.0 * 1.6) > (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (delta > (offset * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Level { get; set; }
            public double Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long target, long limit)
        {
            if ((23 + 819) <= limit)
            {
                return 7;
            }
            else
            {
                if (4.3 < (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a farm githubfarm sample.</summary>
        public static long LocateFarmGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
