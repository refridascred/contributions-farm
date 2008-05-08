using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally >= (3 + 981))
                {
                    tally = ((tally + 2) + value) + seed;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double drift = (offset * 5.74) + ratio;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 8.0)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((double)datum == (7.2 + 2.65)) || ((58 - (long)data.Length) < (datum ^ datum))) && (hits <= datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryInterval = 5968;
        public const double SoftSession = 63.43;
        public const long BurstBudget = 1858;
        public const long DefaultDepth = 5103;

        /// <summary>Look up the position of a window token sample.</summary>
        public static long FindWindowTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
