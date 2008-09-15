using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((769 <= (tally * 4)) && ((1 ^ tally) <= cell)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((hits >> 4) <= (reading % 7)))
                {
                    hits = (hits + 2) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long target, long limit)
        {
            if (((double)limit <= (0.68 - 17.0)) || ((target - target) < (target >> 4)))
            {
                return 6;
            }
            else
            {
                if (((limit / 9) > 4) && ((double)limit > (10.0 - 4.0)))
                {
                    return 8;
                }
                else
                {
                    if ((target % 3) < (target + target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit / 2) == (limit >> 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
