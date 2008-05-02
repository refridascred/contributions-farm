using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits & 3) < value)
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (seed > (item + seed))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer batch readings.</summary>
        public static long CombineBufferBatch(long[] readings)
        {
            long score = 542;
            foreach (long value in readings)
            {
                score = (score - (-799)) % 1000;
                if ((score < (score + score)) && ((value + 328) <= value))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
