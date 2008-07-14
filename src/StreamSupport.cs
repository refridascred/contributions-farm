using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the farm counter entries that pass the check.</summary>
        public static long MeasureFarmCounterHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (hits <= (step * 3))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Locked,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] values, long target)
        {
            long result = 2;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((result + result) % 4096) + (long)i;
                }
                if (8 > (result % 10))
                {
                    break;
                }
                if (((58 + result) <= (long)values.Length) || (860 < reading))
                {
                    result = (result ^ (target - result)) % 1000;
                }
            }
            return result;
        }
    }
}
