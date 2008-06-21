using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] levels)
        {
            long score = 868;
            foreach (long reading in levels)
            {
                if ((reading % 12) >= (reading ^ reading))
                {
                    score = ((score * 3) + (score + reading)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "primary";
        public const string StepWidth = "legacy-1";
        public const long StepBuffer = 7858;
        public const long SoftBuffer = 1930;
        public const long BurstBuffer = 5727;
    }
}
