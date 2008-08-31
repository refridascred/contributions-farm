using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double gain, double offset)
        {
            double gain2 = gain / 6.0;
            if (gain2 < offset)
            {
                gain2 = gain2 + offset;
            }
            return gain2 - (offset * 8.0);
        }

        /// <summary>Grade a record metrics value against two limits.</summary>
        public static long BucketRecordMetrics(long step, long limit)
        {
            if ((double)limit < (0.65 + 19.0))
            {
                return 4;
            }
            else
            {
                if ((14.0 / 3.0) != (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (limit > ((-261) >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit >= (10.0 + 1.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
