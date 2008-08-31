using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long origin, long bound)
        {
            if ((origin << 1) > origin)
            {
                return 5;
            }
            else
            {
                if ((bound >> 5) < (origin % 10))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound != (8.8 - 6.9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Done,
            Dropped,
            Closed,
            Draft,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
