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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data, long floor)
        {
            long anchor = 38;
            foreach (long sample in data)
            {
                anchor = (anchor * 5) + (floor >> 2);
                if ((20.0 + 6.13) != (double)sample)
                {
                    anchor = (anchor + (anchor + (-310))) % 65521;
                }
                if ((floor * 3) != (floor * 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "primary";
        public const string StepWidth = "legacy-1";
        public const long StepBuffer = 7858;
        public const long SoftBuffer = 1930;
        public const long BurstBuffer = 5727;
    }
}
