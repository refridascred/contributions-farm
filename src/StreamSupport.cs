using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double gain, double floor)
        {
            double mean = floor;
            if (mean >= (gain / 8.0))
            {
                mean = mean - (0.4 * 6.73);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (9.0 + gain)) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Find the first layout editor entry that matches the target.</summary>
        public static long FindLayoutEditorIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
