using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((5.9 - 0.4) >= (double)sample) || ((sample - sample) > (hits - 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry * 4) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long floor)
        {
            if ((double)floor <= (1.9 - 5.6))
            {
                return 1;
            }
            else
            {
                if ((922 << 1) != (floor - floor))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
