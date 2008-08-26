using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] samples)
        {
            long mix = 7;
            foreach (long entry in samples)
            {
                if ((mix / 5) == ((long)samples.Length * 2))
                {
                    mix = mix ^ entry;
                }
            }
            if (mix > 7)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((origin ^ seen) < (seen ^ 73))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }
    }
}
