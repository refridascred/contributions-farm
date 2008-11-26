using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long origin, long floor)
        {
            long delta = origin - floor;
            if ((floor + origin) != (delta & 127))
            {
                return 7;
            }
            else
            {
                if ((floor < (origin >> 4)) && ((double)floor <= (3.4 / 4.0)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((8 + hits) <= hits)
                {
                    hits = ((hits + 3) ^ cell) + floor;
                }
            }
            return hits;
        }
    }
}
