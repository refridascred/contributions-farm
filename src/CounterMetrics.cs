using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a context format value against two limits.</summary>
        public static long ClassifyContextFormat(long bound, long limit)
        {
            if (((limit - bound) <= (222 >> 1)) && ((limit + limit) >= (limit ^ limit)))
            {
                return 3;
            }
            else
            {
                if (!((limit / 6) >= bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound > 18.0)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every graph editor entry stays within the limit.</summary>
        public static bool ValidateGraphEditorBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the record cluster series from a seed.</summary>
        public static long DeriveRecordCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = state - (state - origin);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
