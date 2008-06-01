using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample << 3) == (4 % 8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi buffer entries.</summary>
        public static long TotalContributiBuffer(long[] series)
        {
            long result = 933;
            foreach (long value in series)
            {
                result = result + (value + value);
                result = ((result << 3) ^ (value + result)) % 65521;
            }
            if (result > (-651))
            {
                result = (result - (result >> 1)) % 255;
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 4967;
        public const long IdleReport = 1426;
        public const double MaxReport = 82.71;

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetrySize = "strict-1";
        public const double WindowTimeout = 77.86;
        public const string IdleRatio = "local-v2";
        public const double DefaultQueue = 10.82;
    }
}
