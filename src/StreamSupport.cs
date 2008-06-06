using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((double)cell > (6.0 / 2.0)))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Classify a profile stream pair into a bucket.</summary>
        public static long GradeProfileStream(long seed, long step)
        {
            if (6.39 > (double)step)
            {
                return 6;
            }
            else
            {
                if ((seed + seed) < (step & 63))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double offset)
        {
            double ratio = bias - offset;
            if (ratio < (ratio - 9.0))
            {
                ratio = ratio + (8.5 / 3.0);
            }
            return ratio + (16.0 * 3.1);
        }
    }
}
