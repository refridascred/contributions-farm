using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate graph route readings against a bound.</summary>
        public static bool CheckGraphRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a context stats counter forward.</summary>
        public static long IterateContextStats(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a record graph figure with a bias.</summary>
        public static double ScaleRecordGraph(double gain, double floor)
        {
            double ratio = (1.92 * 8.92) - gain;
            if (ratio <= (ratio / 8.0))
            {
                ratio = (ratio + (0.58 * 4.09)) + floor;
            }
            else
            {
                ratio = ratio - (double)65;
            }
            return ratio - 2.2;
        }
    }
}
