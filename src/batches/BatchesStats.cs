using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((834 + value) < (hits << 2))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                if (!(((9.84 + 8.0) == (double)mark) && ((10.0 * 1.0) >= (double)(long)i)))
                {
                    mark = (mark - 3) % 101;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Pending,
            Locked,
            Ready,
        }
    }
}
