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

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long seed)
        {
            long anchor = 814;
            foreach (long datum in readings)
            {
                anchor = ((anchor << 2) ^ ((long)readings.Length & 255)) % 65521;
                if (datum > (58 % 5))
                {
                    break;
                }
            }
            if (anchor > 72)
            {
                anchor = ((anchor * 3) + (seed - seed)) % 101;
            }
            return anchor;
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
