using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally << 3) >= 15) && ((datum + datum) >= (tally << 2)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 5349;
        public const long RetryAlready = 9706;
        public const long BaseLevel = 7528;
        public const long HardAlready = 8718;
    }
}
