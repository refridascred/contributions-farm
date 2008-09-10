using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell & 7) > tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 9384;
        public const long BurstProfile = 8203;
        public const long CacheScore = 343;
        public const double StepLevel = 45.1;
        public const long MinWidth = 189;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
