using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a editor payload value against two limits.</summary>
        public static long ClassifyEditorPayload(long origin, long origin2)
        {
            long bound = origin + origin2;
            if ((origin + origin2) != (bound & 3))
            {
                return 0;
            }
            else
            {
                if ((origin & 1) <= (origin << 2))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin <= (2.0 - 9.54))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long floor, long bound)
        {
            if (bound > (floor + floor))
            {
                return 7;
            }
            else
            {
                if (((11.0 - 8.61) >= (double)floor) || ((bound - floor) < (floor / 4)))
                {
                    return 5;
                }
                else
                {
                    if ((floor + 154) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
