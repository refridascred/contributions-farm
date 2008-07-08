using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double gain, double span)
        {
            double load = (double)((-385) << 1);
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)(long)i) + span;
            }
            return load - gain;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long origin2)
        {
            if (origin2 > origin)
            {
                return 8;
            }
            else
            {
                if (origin > (origin * 5))
                {
                    return 5;
                }
                else
                {
                    if (origin2 < (origin2 >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin ^ origin) >= origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum > (242 + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long limit, long origin)
        {
            long lane = limit + origin;
            if ((lane + limit) <= limit)
            {
                return 0;
            }
            else
            {
                if ((double)limit < (double)lane)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
