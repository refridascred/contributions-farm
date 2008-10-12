using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryBudget = 53.56;
        public const string WindowFilter = "stable-1";
        public const long SoftFilter = 7819;
        public const long BurstFilter = 794;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double rate, double span)
        {
            double ratio = (rate * 2.5) + span;
            return ratio + (double)(-702);
        }
    }
}
