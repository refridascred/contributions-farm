using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up tools commits samples.</summary>
        public static long OverlapToolsCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 4) + ((long)i + limit)) % 4096) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long target)
        {
            long next = floor ^ target;
            if ((next < (39 << 3)) && ((next >> 1) >= floor))
            {
                return 8;
            }
            else
            {
                if (((target & 15) > (target / 9)) && (845 >= next))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
