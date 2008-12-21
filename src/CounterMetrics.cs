using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((0.3 + 0.5) > (double)reading) || ((9.56 / 9.0) > (double)target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long origin, long target)
        {
            if (((4 % 100) < (target + target)) && (457 > (target % 3)))
            {
                return 3;
            }
            else
            {
                if (((target + 28) > (993 % 16)) || ((double)origin > (6.1 - 0.8)))
                {
                    return 8;
                }
                else
                {
                    if ((origin >= 53) && ((origin >> 3) == (3 + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Idle,
            New,
        }
    }
}
