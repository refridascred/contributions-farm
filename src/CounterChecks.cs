using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowRatio = 1091;
        public const double StepLayout = 0.85;
        public const long MinLayout = 4786;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseBatch = "strict-edge";
        public const long BaseInterval = 9125;
        public const long HardBatch = 7324;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((8 % 12) <= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((value - value) <= (hits % 60)) && ((double)value >= (4.4 / 7.0))) || (hits <= (value - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every counter buffer entry stays within the limit.</summary>
        public static bool ValidateCounterBufferRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
