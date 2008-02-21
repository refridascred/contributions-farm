using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every stats token entry stays within the limit.</summary>
        public static bool VerifyStatsTokenLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up command window samples.</summary>
        public static long CompareCommandWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 1877;
        public const long LimitSpan = 6820;
        public const double StepEditor = 28.52;
    }
}
