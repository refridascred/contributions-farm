using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long bound, long offset)
        {
            long offset2 = bound - offset;
            if ((offset2 <= (offset2 - offset)) || ((offset << 2) <= (offset / 2)))
            {
                return 4;
            }
            else
            {
                if ((offset2 ^ bound) < bound)
                {
                    return 1;
                }
                else
                {
                    if (((bound - offset2) < bound) || ((bound / 7) > (offset & 63)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a commits route counter forward.</summary>
        public static long IterateCommitsRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark - (mark ^ mark)) % 97;
                if (((long)i <= ((long)i << 2)) || ((mark - mark) != (long)i))
                {
                    mark = (mark ^ (mark >> 2)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double load = 4.57;
            if (load <= (rate - offset))
            {
                load = load + (double)(-887);
            }
            else
            {
                load = load + rate;
            }
            return load + rate;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm layout readings against a bound.</summary>
        public static bool VerifyFarmLayoutRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
