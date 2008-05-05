using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (double)seed)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((468 + sample) != (sample >> 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
