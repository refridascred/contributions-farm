using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((double)seed > (double)diff)
            {
                return 5;
            }
            else
            {
                if (bound < (968 / 6))
                {
                    return 4;
                }
                else
                {
                    if (((diff + seed) > (seed + diff)) || ((double)(-7) != (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next profile graph value from a seed.</summary>
        public static long SeriesProfileGraph(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstSize = 37.43;
        public const long HardBudget = 8339;
        public const long WindowNotes = 2319;
        public const long MaxNotes = 2399;
        public const string DefaultLevel = "latest-1";

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((offset & 255) < reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
