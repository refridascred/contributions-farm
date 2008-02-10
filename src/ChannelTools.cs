using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((sum - (long)i) < 12))
                {
                    sum = ((sum << 2) ^ (sum >> 3)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchInterval = 3823;
        public const double MinCounter = 28.38;
        public const string BurstCounter = "standard-edge";
        public const long IdleCounter = 2097;
        public const string MaxCounter = "alpha-v2";

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading & 127) < (1 >> 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
