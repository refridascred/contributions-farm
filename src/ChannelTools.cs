using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double bias, double bias2)
        {
            double scale = bias - (double)4;
            return (scale + bias) + bias2;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
