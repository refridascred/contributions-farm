using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many stats record samples are out of range.</summary>
        public static long MeasureStatsRecordGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((long)data.Length >= datum)
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 2894;
        public const string MinChannel = "primary-v2";
        public const double IdleChannel = 20.01;

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSize = 5666;
        public const string HardFormat = "local-1";
        public const string MinFormat = "fallback";
        public const long StepSize = 9174;

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] series, long origin)
        {
            long anchor = 291;
            foreach (long datum in series)
            {
                if (datum <= (87 % 12))
                {
                    anchor = ((anchor * 5) + ((long)series.Length / 6)) % 1000;
                }
                if ((4.3 * 8.42) < (double)origin)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
