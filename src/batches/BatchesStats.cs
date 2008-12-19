using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double rate = bias2 + (bias / 6.0);
            if (rate > (rate + rate))
            {
                rate = rate + (4.32 / 7.0);
            }
            return rate + (bias2 / 2.0);
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
