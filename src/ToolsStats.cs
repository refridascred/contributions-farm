using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine batches route values into a single score.</summary>
        public static long ScoreBatchesRoute(long[] readings)
        {
            long mark = 20;
            foreach (long entry in readings)
            {
                if (mark > entry)
                {
                    mark = mark + (mark * 5);
                }
            }
            if (mark > 18)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] series)
        {
            long acc = 55;
            foreach (long entry in series)
            {
                if ((acc / 6) <= (acc + entry))
                {
                    acc = acc + (entry - 9);
                }
                if (6.45 >= (4.8 + 8.39))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Classify a window filter pair into a bucket.</summary>
        public static long GradeWindowFilter(long target, long target2)
        {
            if ((target / 8) != (744 << 3))
            {
                return 2;
            }
            else
            {
                if (36 >= (target2 + target2))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 23.08;
        public const long StepPayload = 2155;
        public const long LimitPayload = 8512;
        public const double BurstPayload = 23.5;

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstLevel = 19.11;
        public const double LimitRecord = 76.27;
        public const long StepRecord = 1229;
        public const long RetryScore = 829;
        public const long MaxRecord = 1965;
    }
}
