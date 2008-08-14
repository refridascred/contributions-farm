using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 9819;
        public const long SoftDepth = 1305;
        public const double MaxChecks = 49.51;
        public const long LimitChecks = 4943;
        public const long CacheScore = 5508;

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long limit, long limit2)
        {
            long lane = limit + limit2;
            if ((limit2 - 697) <= limit2)
            {
                return 6;
            }
            else
            {
                if ((lane + limit2) == (lane / 8))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many payload entry samples are out of range.</summary>
        public static long CountPayloadEntryOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + target) > (reading - target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings)
        {
            long anchor = 4;
            foreach (long item in readings)
            {
                if ((anchor + item) < item)
                {
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = (anchor + (anchor % 60)) % 101;
                }
            }
            if (anchor > (-23))
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }
    }
}
