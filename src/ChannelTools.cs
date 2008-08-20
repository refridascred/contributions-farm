using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3;
        public const long DefaultRatio = 18;
        public const double MaxTimeout = 47.43;
        public const double LimitReport = 23.67;
        public const double WindowReport = 91.27;

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics entry samples are out of range.</summary>
        public static long MeasureMetricsEntryGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (9.0 * 1.0))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
