using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of command batches readings.</summary>
        public static long FoldCommandBatches(long[] levels)
        {
            long sum = 63;
            foreach (long cell in levels)
            {
                sum = ((sum + (sum / 5)) % 4096) + cell;
            }
            if (sum < (-586))
            {
                sum = (sum ^ (-8)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long origin, long step)
        {
            if (((double)origin == (14.0 - 1.0)) || (step < origin))
            {
                return 1;
            }
            else
            {
                if ((step + 5) <= (3 & 127))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin < (4.74 - 15.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 5) >= 36)
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
    }
}
