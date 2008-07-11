using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the payload notes series from a seed.</summary>
        public static long RollPayloadNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix << 2) ^ step;
                mix = ((mix << 2) ^ (long)i) % 101;
                mix = ((mix * 4) + step) % 255;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Derive the next counter already value from a seed.</summary>
        public static long StepCounterAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
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
