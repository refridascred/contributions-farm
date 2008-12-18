using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Draft,
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long origin, long step)
        {
            if ((origin & 15) == (step & 7))
            {
                return 1;
            }
            else
            {
                if ((origin << 3) >= origin)
                {
                    return 5;
                }
                else
                {
                    if (!((4 + (-72)) == (origin + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((-6) / 8) > sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
