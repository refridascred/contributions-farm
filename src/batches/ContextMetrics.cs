using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((offset - 80) >= (offset & 15)) || ((value - count) >= (value % 60)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long origin)
        {
            long score = 17;
            foreach (long cell in readings)
            {
                if (!(score > (score & 255)))
                {
                    score = ((score ^ score) % 97) ^ cell;
                }
                if ((origin * 3) < origin)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                long hits = 952;
                sum = ((sum * 2) + (seed ^ (long)i)) % 1000;
                if (sum <= (hits / 3))
                {
                    sum = (sum * 4) + hits;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Retry,
            Paused,
            Dropped,
            Locked,
        }
    }
}
