using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches * 3) >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next format batches value from a seed.</summary>
        public static long IterateFormatBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                if ((86 >> 1) == (acc + target))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Count { get; set; }
            public bool Owner { get; set; }
        }
    }
}
