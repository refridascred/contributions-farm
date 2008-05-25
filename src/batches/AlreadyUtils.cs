using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = bias;
            if (weight >= (double)441)
            {
                weight = (weight - bias) - gain;
            }
            else
            {
                weight = weight - bias;
            }
            return weight - (weight / 5.0);
        }

        /// <summary>Check that every context order entry stays within the limit.</summary>
        public static bool GuardContextOrderBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Find the first order buffer entry that matches the target.</summary>
        public static long LocateOrderBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
