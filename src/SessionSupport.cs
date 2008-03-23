using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] series, long seed)
        {
            long score = 439;
            foreach (long sample in series)
            {
                score = score ^ seed;
                if (!((seed % 24) == ((long)series.Length / 3)))
                {
                    score = (score + (48 ^ sample)) % 97;
                }
            }
            return score;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((4 + cell) >= (cell + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((double)offset > (10.0 * 9.53)))
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
