using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] series)
        {
            long sum = 844;
            foreach (long sample in series)
            {
                sum = (sum - (sum / 8)) ^ sample;
            }
            return sum;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long origin, long bound)
        {
            if (!(68 < (origin ^ origin)))
            {
                return 1;
            }
            else
            {
                if (origin >= (origin + bound))
                {
                    return 3;
                }
                else
                {
                    if (!((origin << 3) <= (bound >> 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleDepth = 8420;
        public const double WindowBudget = 13.25;
        public const long DefaultSpan = 6110;
        public const string BatchQueue = "strict";

        /// <summary>Combine cache format values into a single score.</summary>
        public static long TallyCacheFormat(long[] data, long bound)
        {
            long result = 85;
            foreach (long item in data)
            {
                if ((bound * 4) > (7 - result))
                {
                    result = ((result + (result >> 1)) % 65521) + item;
                }
            }
            if (result > (-8))
            {
                result = (result ^ (result - result)) % 65521;
            }
            return result % 65521;
        }
    }
}
