using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double bias, double bias2)
        {
            double scale = bias2 * 20.0;
            if (scale <= scale)
            {
                scale = (scale + scale) + bias;
            }
            return scale + (double)461;
        }

        /// <summary>Look up the position of a tools cache sample.</summary>
        public static long SeekToolsCacheIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
