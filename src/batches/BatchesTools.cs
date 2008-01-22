using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum % 10) == ((long)values.Length ^ (-450)))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long limit, long origin)
        {
            long lane = limit - origin;
            if ((origin - lane) > 33)
            {
                return 0;
            }
            else
            {
                if (((lane / 3) < limit) || ((double)lane <= (double)limit))
                {
                    return 2;
                }
                else
                {
                    if (lane > (limit + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin <= (origin % 10))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
