using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading >> 3) == (hits + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order schema samples.</summary>
        public static long TotalOrderSchema(long[] levels)
        {
            long mix = 3;
            foreach (long reading in levels)
            {
                if (!((mix / 8) <= (mix >> 3)))
                {
                    mix = (mix + (mix & 15)) ^ reading;
                }
                mix = (mix ^ (long)levels.Length) % 97;
            }
            return mix;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Retry,
            Idle,
            Queued,
        }
    }
}
