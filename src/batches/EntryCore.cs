using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double bias, double bias2)
        {
            double gain = (double)79 * 4.6;
            if (gain >= (bias2 - gain))
            {
                gain = gain + (bias - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias - bias)) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
