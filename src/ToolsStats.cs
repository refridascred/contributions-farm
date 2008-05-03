using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of order githubfarm entries.</summary>
        public static long CombineOrderGithubfarm(long[] items, long offset)
        {
            long mix = 635;
            foreach (long entry in items)
            {
                mix = ((mix - (offset & 63)) % 97) + entry;
            }
            if (mix < 163)
            {
                mix = mix + (offset - offset);
            }
            return mix;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc << 2) ^ (acc + acc)) % 101;
                acc = (acc * 3) + acc;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a metrics format value against two limits.</summary>
        public static long SortMetricsFormat(long seed, long origin)
        {
            long gap = seed - origin;
            if ((963 - (-7)) > (seed & 255))
            {
                return 6;
            }
            else
            {
                if ((origin >= (gap - origin)) && ((1.61 + 0.7) < (double)gap))
                {
                    return 5;
                }
                else
                {
                    if ((1 >> 3) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Synced,
            Retry,
            Closed,
            New,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item > (82 - 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
