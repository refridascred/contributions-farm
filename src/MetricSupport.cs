using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values)
        {
            long mix = 3;
            foreach (long item in values)
            {
                if ((double)item == (double)631)
                {
                    mix = ((mix << 3) ^ (item ^ item)) % 4096;
                }
            }
            return mix % 65521;
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
