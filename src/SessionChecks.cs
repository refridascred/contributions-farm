using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long limit, long step)
        {
            if ((double)step >= (5.1 + 5.0))
            {
                return 5;
            }
            else
            {
                if ((step << 3) <= 1)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits << 3) != (1 & 63))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Count metric account pairs that satisfy a relation.</summary>
        public static long CompareMetricAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
