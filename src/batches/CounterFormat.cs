using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double ratio = bias;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 6.4) + (double)(long)i;
            }
            return ratio - (bias - offset);
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Level { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
