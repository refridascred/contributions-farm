using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepInterval = 2473;
        public const double RetryLayout = 7.6;
        public const string HardLayout = "fallback";
        public const string MinLayout = "strict-1";
        public const double BurstInterval = 42.07;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((long)series.Length - value) <= (count + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] data)
        {
            long score = 19;
            foreach (long entry in data)
            {
                if ((entry + entry) != ((-179) + entry))
                {
                    score = (score - entry) % 97;
                }
            }
            if (score > 259)
            {
                score = score + (score & 3);
            }
            return score;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((2.5 - 4.0) == (double)matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
