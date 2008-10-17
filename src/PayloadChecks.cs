using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 7;
        public const double RetryEntry = 74.48;
        public const long BurstEntry = 4541;
        public const long StepEntry = 7391;
        public const string WindowEntry = "legacy-v2";

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) < (reading & 63))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + cell) == (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - item) > (96 + item))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double mean = rate;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (3.0 * 14.0)) + (double)(long)i) - floor;
            }
            return mean - (3.0 / 9.0);
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
