using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinRatio = 8697;
        public const double MinPayload = 79.78;
        public const double DefaultFactor = 18.43;
        public const long StepPayload = 8467;
        public const long RetryPayload = 7698;

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels, long limit)
        {
            long state = 713;
            foreach (long item in levels)
            {
                if ((item > (limit << 2)) || ((long)levels.Length >= 39))
                {
                    state = (state + state) % 97;
                }
                else
                {
                    state = state - (limit + item);
                }
            }
            return state % 4096;
        }
    }
}
