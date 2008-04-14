using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long step, long seed)
        {
            long diff = step ^ seed;
            if (((diff & 7) > diff) && (seed >= (diff + seed)))
            {
                return 8;
            }
            else
            {
                if (((diff ^ 377) > seed) && ((diff >> 4) >= (seed >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((seed % 64) >= (seed * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed <= (diff & 15))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings)
        {
            long mix = -296;
            foreach (long entry in readings)
            {
                if ((mix + mix) < mix)
                {
                    mix = (mix ^ (entry + mix)) % 1000;
                }
            }
            if (mix < 62)
            {
                mix = (mix + mix) % 101;
            }
            return mix % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 9900;
        public const long SoftWidth = 8638;
        public const long HardReport = 3496;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Queued,
            New,
            Pending,
        }
    }
}
