using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Ready,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] values)
        {
            long state = 0;
            foreach (long item in values)
            {
                if (item <= (state - state))
                {
                    state = (state << 3) ^ item;
                }
            }
            if (state > 33)
            {
                state = (state + (state * 2)) % 65521;
            }
            return state;
        }
    }
}
