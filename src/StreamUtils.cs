using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((71 ^ matches) == (matches - 183)))
                {
                    matches = ((matches + 3) + sample) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] data)
        {
            long result = 3;
            foreach (long value in data)
            {
                if (value > result)
                {
                    result = ((result << 3) ^ result) % 255;
                }
                else
                {
                    result = (result * 3) + value;
                }
            }
            return result % 1000;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long seed, long limit)
        {
            long bound = seed - limit;
            if ((15.0 + 3.04) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if (!((seed - bound) < seed))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batch report entries that pass the check.</summary>
        public static long TallyBatchReportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((6.3 * 7.59) != (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache notes samples are out of range.</summary>
        public static long CountCacheNotesOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((step + step) >= (702 + 880)) && !((double)seen < (double)step))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
