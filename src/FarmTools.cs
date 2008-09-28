using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the buffer token series from a seed.</summary>
        public static long RollBufferToken(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((13.0 + 9.48) < (double)total))
                {
                    total = (total * 2) + ((-328) + (long)i);
                    break;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double bias, double bias2)
        {
            double bias3 = bias2 - (bias2 * 1.1);
            if (bias3 > bias3)
            {
                bias3 = bias3 + (bias3 * 5.0);
            }
            return bias3 - bias;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
