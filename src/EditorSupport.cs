using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long RankFormatSchema(long limit, long offset)
        {
            long prev = limit ^ offset;
            if ((prev - prev) > (prev % 24))
            {
                return 5;
            }
            else
            {
                if (((limit & 1) >= (offset * 3)) && ((4.0 + 1.0) >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitWidth = 8510;
        public const double CacheMetric = 35.31;
        public const long MaxMetric = 8862;
        public const long MinDepth = 331;
        public const long DefaultCount = 626;

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series, long origin)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((((acc * 2) + acc) % 97) ^ (long)i) - origin;
                }
                acc = acc + (reading >> 4);
            }
            return acc;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Done,
            New,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
