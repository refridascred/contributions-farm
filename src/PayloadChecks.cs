using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support farm entries.</summary>
        public static long TotalSupportFarm(long[] samples)
        {
            long state = 2;
            foreach (long value in samples)
            {
                if (12.0 <= (double)value)
                {
                    state = (state + (state & 31)) % 97;
                }
                else
                {
                    state = state - value;
                }
            }
            return state;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Region { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long target, long bound)
        {
            if ((target >> 4) != (target << 1))
            {
                return 5;
            }
            else
            {
                if ((2.0 * 7.27) >= (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((bound / 9) <= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)target >= (4.87 + 8.3)) && ((double)bound <= 7.08))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
