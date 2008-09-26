using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a farm support value against two limits.</summary>
        public static long BucketFarmSupport(long step, long target)
        {
            if ((target / 7) <= step)
            {
                return 1;
            }
            else
            {
                if ((step + step) == (step * 2))
                {
                    return 8;
                }
                else
                {
                    if (step <= (target * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step * 2) >= target) && (target <= (target - 59)))
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
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings, long limit)
        {
            long anchor = 3;
            foreach (long datum in readings)
            {
                anchor = (((anchor - (anchor + 3)) % 101) ^ datum) - limit;
            }
            return anchor % 1000;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
