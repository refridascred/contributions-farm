using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 11.74;
        public const double RetryFormat = 68.75;
        public const double MaxInterval = 4.79;
        public const long DefaultInterval = 6318;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long step, long target)
        {
            long lane = step - target;
            if (lane <= (step + step))
            {
                return 1;
            }
            else
            {
                if (((target ^ lane) < (step / 7)) || ((step * 4) > (step >> 1)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit graph command readings against a rule.</summary>
        public static long AuditGraphCommandGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)bound >= 7.52)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
