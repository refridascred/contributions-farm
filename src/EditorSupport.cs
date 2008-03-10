using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next commits contributi value from a seed.</summary>
        public static long SeriesCommitsContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = (total - (total << 1)) % 1000;
                if (((seed + (-707)) <= seed) || (((long)i + total) < (seed ^ 479)))
                {
                    total = (total * 4) + (70 << 2);
                }
                if (((total & 127) > (56 - seed)) && ((double)seed > 0.67))
                {
                    total = (total ^ total) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double gain, double bias)
        {
            double ratio = gain;
            if (ratio <= (double)958)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio - (bias / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)1) + (double)(long)i;
            }
            return ratio - (double)(-465);
        }

        /// <summary>Combine cache graph values into a single score.</summary>
        public static long TotalCacheGraph(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long sample in samples)
            {
                if ((carry & 31) >= carry)
                {
                    carry = (carry << 2) ^ (carry + seed);
                }
                else
                {
                    carry = (carry + (sample - seed)) % 4096;
                }
            }
            if (carry < 95)
            {
                carry = carry - (seed ^ seed);
            }
            return carry;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
