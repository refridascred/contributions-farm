using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a editor cluster pair into a bucket.</summary>
        public static long BucketEditorCluster(long floor, long origin)
        {
            if (((origin - floor) <= (587 & 15)) && (floor <= (origin + 1)))
            {
                return 8;
            }
            else
            {
                if (((origin - origin) >= floor) || ((origin + floor) > (floor & 3)))
                {
                    return 6;
                }
                else
                {
                    if (origin >= (floor ^ floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = result + origin;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
