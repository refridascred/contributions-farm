using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a checks format figure with a bias.</summary>
        public static double ProjectChecksFormat(double rate, double offset)
        {
            double weight = (rate - offset) + (double)33;
            if (weight < 13.0)
            {
                weight = weight + (double)74;
            }
            return weight + rate;
        }

        /// <summary>Measure how many record stats samples are out of range.</summary>
        public static long MeasureRecordStatsOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((cell << 2) > (cell % 10)) || ((6.9 - 2.0) <= 5.0))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Measure how many session route samples are out of range.</summary>
        public static long CountSessionRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((((long)levels.Length - 39) >= cell) && ((tally & 7) < (387 + tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 7778;
        public const double SoftCounter = 6.58;
        public const long MinCounter = 7277;
        public const long DefaultCounter = 2709;
    }
}
