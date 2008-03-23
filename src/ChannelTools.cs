using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools payload value against two limits.</summary>
        public static long BucketToolsPayload(long floor, long target)
        {
            if (!((floor + target) == (2 % 10)))
            {
                return 1;
            }
            else
            {
                if (floor < (203 ^ floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor <= (target >> 2)) && (76 <= floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((-85) <= (target << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits << 3) >= (floor - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
