using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Idle,
            Queued,
            New,
            Ready,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Failed,
            Draft,
            Active,
            New,
            Closed,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long limit)
        {
            long offset2 = offset + limit;
            if ((limit - limit) > offset2)
            {
                return 6;
            }
            else
            {
                if ((double)offset2 >= (4.6 - 0.9))
                {
                    return 5;
                }
                else
                {
                    if (((4.01 / 3.0) > (double)limit) && (5 <= (limit >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double scale, double offset)
        {
            double rate = (offset * 1.9) / 3.0;
            if (rate > offset)
            {
                rate = rate - (scale * 1.28);
            }
            return rate + (scale + scale);
        }
    }
}
