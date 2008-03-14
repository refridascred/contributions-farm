using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a entry already pair into a bucket.</summary>
        public static long BucketEntryAlready(long origin, long origin2)
        {
            if ((5.8 / 4.0) == (double)origin)
            {
                return 4;
            }
            else
            {
                if ((origin << 2) <= (origin2 << 3))
                {
                    return 3;
                }
                else
                {
                    if (!((origin2 & 1) <= (origin2 + 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin2 > (5.06 * 13.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] samples)
        {
            long result = 64;
            foreach (long cell in samples)
            {
                result = ((result * 2) + result) ^ cell;
                if ((result % 24) < (result << 2))
                {
                    result = result + result;
                }
            }
            if (result < (-4))
            {
                result = (result - (result + 2)) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of batch metric readings.</summary>
        public static long CombineBatchMetric(long[] series)
        {
            long anchor = 3;
            foreach (long cell in series)
            {
                if ((cell * 3) <= anchor)
                {
                    anchor = anchor - (cell & 255);
                }
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 7523;
        public const long WindowChannel = 2003;
        public const long IdleFactor = 1927;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i + (long)i) < (sum & 15))
                {
                    sum = (sum - (limit - limit)) % 1000;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Synced,
            Stale,
            Dropped,
        }
    }
}
