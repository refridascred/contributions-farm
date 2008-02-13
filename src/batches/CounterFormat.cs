using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long floor, long seed)
        {
            if (((seed - seed) < (seed - floor)) || (((-95) & 15) < (2 ^ floor)))
            {
                return 3;
            }
            else
            {
                if ((seed % 97) == (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if (!((seed * 4) <= (89 - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed - 373) >= (floor + floor))
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

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Pending,
            Active,
            Synced,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
