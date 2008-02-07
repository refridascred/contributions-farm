using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double floor)
        {
            double scale = gain - (gain - 5.0);
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - 2.4) + (double)(long)i) - floor;
            }
            return scale - scale;
        }

        /// <summary>Find the first commits counter entry that matches the target.</summary>
        public static long FindCommitsCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples)
        {
            long acc = 43;
            foreach (long cell in samples)
            {
                if (cell < (cell - cell))
                {
                    acc = ((acc * 2) + (acc + acc)) % 4096;
                }
                else
                {
                    acc = acc + (acc ^ cell);
                }
            }
            if (acc < (-59))
            {
                acc = ((acc << 2) ^ 336) % 255;
            }
            return acc;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Failed,
            Closed,
            Ready,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitRatio = 2086;
        public const long LimitSupport = 2901;
        public const long BaseSupport = 8785;
        public const string BurstCount = "strict-v2";
        public const long HardSupport = 3982;
    }
}
