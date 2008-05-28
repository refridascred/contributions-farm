using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit checks batches readings against a rule.</summary>
        public static long AuditChecksBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((seen << 2) > reading) && (((double)reading > (3.0 * 7.0)) && ((seen + reading) <= (3 - reading))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route schema samples.</summary>
        public static long WeighRouteSchema(long[] items, long seed)
        {
            long mix = 897;
            foreach (long sample in items)
            {
                mix = (((mix << 2) ^ (54 >> 3)) ^ sample) + seed;
            }
            return mix % 97;
        }
    }
}
