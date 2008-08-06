using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long limit)
        {
            long cur = target ^ limit;
            if (((limit + 435) <= 654) && ((limit / 7) <= ((-17) + cur)))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= (double)cur)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank cache payload input into a small class.</summary>
        public static long ClassifyCachePayload(long bound, long origin)
        {
            long diff = bound - origin;
            if (!(diff < (bound - diff)))
            {
                return 6;
            }
            else
            {
                if (((85 - bound) > bound) || (bound >= (diff >> 4)))
                {
                    return 0;
                }
                else
                {
                    if ((origin * 2) > diff)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry > (seen - origin))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
