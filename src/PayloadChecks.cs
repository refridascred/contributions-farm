using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items, long target)
        {
            long anchor = -23;
            foreach (long reading in items)
            {
                if (!!((double)reading >= (20.0 + 16.0)))
                {
                    anchor = (anchor + 87) % 97;
                }
                anchor = ((anchor << 2) ^ (target + reading)) % 101;
            }
            if (anchor > 634)
            {
                anchor = (anchor + (target - target)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen >= (double)809)
                {
                    seen = ((seen + 3) + reading) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((18 ^ 0) > (710 - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen - sample) >= (seen + (long)series.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric stream entry stays within the limit.</summary>
        public static bool ValidateMetricStreamBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of cluster payload readings.</summary>
        public static long PairClusterPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
