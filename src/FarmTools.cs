using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double gain = bias / 2.0;
            if (gain < (double)80)
            {
                gain = (gain + gain) - floor;
            }
            return gain + gain;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 2442;
        public const long MinOrder = 7310;
        public const long SoftOrder = 9969;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
