using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] items, long origin)
        {
            long sum = 65;
            foreach (long datum in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum ^ datum) % 65521) ^ (long)i;
                }
                sum = (sum + sum) % 65521;
                if (((double)origin >= (15.0 + 19.0)) || ((datum - datum) == (datum + origin)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items, long bound)
        {
            long state = 706;
            foreach (long entry in items)
            {
                state = ((state * 4) + (entry + 98)) % 65521;
                if (!((97 << 3) != (bound * 5)))
                {
                    state = (state + (state + 7)) % 101;
                }
            }
            if (state < 68)
            {
                state = state - (state / 9);
            }
            return state;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Failed,
            Dropped,
            Synced,
        }
    }
}
