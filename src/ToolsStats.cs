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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long step)
        {
            long delta = bound ^ step;
            if (9 >= (delta << 2))
            {
                return 2;
            }
            else
            {
                if (((step + delta) < step) || ((step + step) < bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound - bound) != (step + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((limit - limit) >= (limit ^ limit))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
