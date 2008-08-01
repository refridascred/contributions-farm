using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long offset2)
        {
            long bound = offset - offset2;
            if ((double)bound <= (4.43 - 3.4))
            {
                return 1;
            }
            else
            {
                if (offset < (offset >> 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long limit)
        {
            long offset = target ^ limit;
            if ((offset - target) == (limit & 3))
            {
                return 2;
            }
            else
            {
                if ((2.0 / 3.0) >= (double)offset)
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
}
