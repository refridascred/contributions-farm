using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count cache command pairs that satisfy a relation.</summary>
        public static long PairCacheCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits >= (datum ^ hits)) || (hits > (hits % 5)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
