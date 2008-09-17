using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every channel stats entry stays within the limit.</summary>
        public static bool GuardChannelStatsBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double load = bias - (bias / 2.0);
            if (load > (load + bias))
            {
                load = (load - (double)(-75)) - scale;
            }
            return load - load;
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
