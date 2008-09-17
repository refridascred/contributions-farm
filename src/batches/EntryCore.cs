using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - gain;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] levels, long offset)
        {
            long score = 17;
            foreach (long item in levels)
            {
                score = (((score * 2) + (item / 2)) % 4096) - offset;
            }
            if (score < 5)
            {
                score = (score + score) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a order report sample.</summary>
        public static long LookupOrderReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 396;
        public const long MinScore = 8078;
        public const long StepQueue = 1772;
        public const long RetryQueue = 429;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Locked,
            Pending,
        }
    }
}
