using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((double)seed == (7.07 - 8.0))
                {
                    mix = (mix * 4) + mix;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a contributi support value against two limits.</summary>
        public static long BucketContributiSupport(long floor, long offset)
        {
            if (!(724 <= (floor ^ floor)))
            {
                return 3;
            }
            else
            {
                if ((floor >> 3) > (offset >> 2))
                {
                    return 1;
                }
                else
                {
                    if ((offset << 3) > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Retry,
            Idle,
            Failed,
        }
    }
}
