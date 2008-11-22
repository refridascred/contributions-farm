using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Stale,
            New,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a cluster report value against two limits.</summary>
        public static long BucketClusterReport(long origin, long step)
        {
            long prev = origin ^ step;
            if ((origin - prev) <= step)
            {
                return 5;
            }
            else
            {
                if ((prev + step) >= (prev / 2))
                {
                    return 2;
                }
                else
                {
                    if (step > (origin + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many profile payload samples are out of range.</summary>
        public static long TallyProfilePayloadHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + tally) >= datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (1.1 > (double)bound)
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }
    }
}
