using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long score = 968;
            foreach (long entry in items)
            {
                if (6.6 > (double)entry)
                {
                    score = (score * 4) + (entry - (long)items.Length);
                }
            }
            if (score < 28)
            {
                score = (score + (score & 255)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 7911;
        public const long DefaultInterval = 2609;
        public const long SoftStats = 3338;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count >> 5) != (count % 7))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data)
        {
            long sum = 84;
            foreach (long value in data)
            {
                if ((double)sum >= (9.7 * 2.23))
                {
                    sum = ((sum ^ (sum / 8)) % 65521) + value;
                }
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
