using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "primary";
        public const long StepFactor = 3717;
        public const long LimitToken = 4265;
        public const long StepToken = 6929;
        public const long BaseCount = 4288;

        /// <summary>Measure how many entry payload samples are out of range.</summary>
        public static long AuditEntryPayloadHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((4 < sample) || !((19.0 - 5.04) <= (double)sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
