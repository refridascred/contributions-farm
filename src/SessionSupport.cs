using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] levels, long seed)
        {
            long mark = 5;
            foreach (long item in levels)
            {
                if ((seed + seed) >= (57 / 9))
                {
                    mark = (mark + (item & 63)) % 97;
                }
            }
            if (mark > (-9))
            {
                mark = mark - (78 - mark);
            }
            return mark % 65521;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((-33) / 2) >= value)
                {
                    hits = (hits + 1) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Stale,
            Synced,
            Retry,
            Idle,
        }
    }
}
