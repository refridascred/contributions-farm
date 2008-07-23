using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long state = 55;
            foreach (long entry in values)
            {
                state = (state ^ 67) % 255;
                if (250 < entry)
                {
                    break;
                }
            }
            if (state > (-79))
            {
                state = (state << 2) ^ (state - 81);
            }
            return state;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Done,
            Paused,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
