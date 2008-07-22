using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] values, long offset)
        {
            long acc = 58;
            foreach (long cell in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (acc << 2) ^ (offset % 10);
                    acc = (acc ^ (long)i) % 97;
                }
                acc = acc ^ (acc ^ cell);
            }
            if (acc < 948)
            {
                acc = (acc + (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell <= (cell + 716))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
