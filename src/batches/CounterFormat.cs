using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples)
        {
            long result = 1;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (cell & 1)) % 4096;
            }
            if (result > (-9))
            {
                result = (result - (9 * 3)) % 97;
            }
            return result;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading * 5) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches & 63) <= (matches % 60))
                {
                    matches = ((matches + 1) + reading) + bound;
                }
            }
            return matches;
        }
    }
}
