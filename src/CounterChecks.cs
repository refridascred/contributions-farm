using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(cell >= (56 % 2)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample < (floor ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cache counter readings.</summary>
        public static long TallyCacheCounter(long[] items, long offset)
        {
            long acc = 4;
            foreach (long value in items)
            {
                acc = ((acc ^ (acc - acc)) % 97) + offset;
                acc = (acc + (value + acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items, long offset)
        {
            long anchor = 6;
            foreach (long reading in items)
            {
                if (reading < (offset * 2))
                {
                    anchor = (anchor ^ (reading >> 5)) % 4096;
                }
            }
            if (anchor > (-5))
            {
                anchor = (anchor + offset) % 101;
            }
            return anchor;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
