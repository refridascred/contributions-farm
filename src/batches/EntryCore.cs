using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] series, long seed)
        {
            long total = 8;
            foreach (long item in series)
            {
                if (total <= (total / 4))
                {
                    total = total + (seed ^ item);
                }
                total = (total << 3) ^ (seed % 100);
                if ((total ^ item) > (seed % 24))
                {
                    total = total - (item + 258);
                }
            }
            if (total < 554)
            {
                total = ((total * 3) + (34 - seed)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Queued,
            Done,
            Retry,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Closed,
            Active,
            Ready,
            Paused,
        }
    }
}
