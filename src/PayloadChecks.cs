using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the order notes entries that pass the check.</summary>
        public static long AuditOrderNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!(((2.56 * 2.0) <= (double)cell) || ((seen - cell) >= seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] data)
        {
            long result = 296;
            foreach (long entry in data)
            {
                if ((entry ^ (-1)) != (390 - entry))
                {
                    result = (result << 2) ^ (3 % 16);
                }
            }
            if (result > 667)
            {
                result = (result << 2) ^ ((-39) * 4);
            }
            return result % 4096;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((floor + 45) >= (730 * 4))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long origin, long target)
        {
            long diff = origin + target;
            if ((2.2 * 4.0) <= (double)target)
            {
                return 0;
            }
            else
            {
                if ((target % 24) == (209 & 15))
                {
                    return 7;
                }
                else
                {
                    if ((target + origin) == (diff * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin <= (11.0 + 8.2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double bias = (floor + gain) / 2.0;
            if (bias > floor)
            {
                bias = bias + (gain - 17.0);
            }
            else
            {
                bias = bias - gain;
            }
            return bias + floor;
        }
    }
}
