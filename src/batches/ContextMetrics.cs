using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long target, long seed)
        {
            long diff = target + seed;
            if ((target <= (target >> 5)) && (target > (seed % 10)))
            {
                return 8;
            }
            else
            {
                if ((diff ^ target) > (target & 7))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank graph support input into a small class.</summary>
        public static long GradeGraphSupport(long limit, long seed)
        {
            long lane = limit - seed;
            if ((lane * 2) < limit)
            {
                return 2;
            }
            else
            {
                if (((-18) ^ limit) <= (lane << 1))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Failed,
            Done,
            Draft,
            Active,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
