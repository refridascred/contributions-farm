using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Dropped,
            Queued,
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long origin)
        {
            long mark = 4;
            foreach (long entry in readings)
            {
                mark = ((mark + (11 - (-946))) % 65521) - origin;
                if ((0 % 24) > entry)
                {
                    mark = (mark + (entry * 5)) % 255;
                }
            }
            if (mark < 49)
            {
                mark = (mark ^ (mark >> 3)) % 97;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 29.64;
        public const double RetryRatio = 93.32;
        public const long DefaultReport = 7097;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((cell & 15) > (cell + cell)))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long limit, long limit2)
        {
            if (((double)limit > (1.3 - 10.0)) || ((limit2 ^ limit2) < limit2))
            {
                return 1;
            }
            else
            {
                if ((limit2 % 7) <= limit2)
                {
                    return 0;
                }
                else
                {
                    if (((double)limit <= (double)limit2) || ((5 + limit) >= (limit - limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (42 > limit2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
