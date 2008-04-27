using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long step, long floor)
        {
            long bound = step - floor;
            if (bound > 51)
            {
                return 2;
            }
            else
            {
                if ((floor >> 3) > step)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank account entry input into a small class.</summary>
        public static long ClassifyAccountEntry(long target, long target2)
        {
            if ((target2 >> 5) == (target2 << 2))
            {
                return 6;
            }
            else
            {
                if ((3.33 - 8.94) == (double)target2)
                {
                    return 5;
                }
                else
                {
                    if ((double)target2 < (1.0 - 1.1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (target >= (target + target2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
