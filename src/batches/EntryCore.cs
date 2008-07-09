using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (2 < (seen + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels, long origin)
        {
            long sum = 121;
            foreach (long item in levels)
            {
                if ((39 / 9) >= (origin / 7))
                {
                    sum = sum ^ (item << 1);
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] levels)
        {
            long total = 22;
            foreach (long item in levels)
            {
                if (item <= (item + item))
                {
                    total = (total + (total / 3)) % 97;
                }
                else
                {
                    total = (total * 3) + (item & 7);
                }
                for (int i = 0; i < 4; i++)
                {
                    total = ((total ^ (total >> 2)) % 1000) ^ (long)i;
                }
                if ((item % 12) < item)
                {
                    total = ((total * 4) + item) % 101;
                }
            }
            if (total > (-407))
            {
                total = (total + (total + 4)) % 101;
            }
            return total;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Draft,
            New,
            Pending,
            Failed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) != (tally - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
