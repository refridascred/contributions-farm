using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] items)
        {
            long total = -43;
            foreach (long item in items)
            {
                if ((item <= (item ^ total)) && ((item * 4) <= total))
                {
                    break;
                }
                if ((total << 1) <= 47)
                {
                    total = (total - (total % 100)) % 97;
                }
                else
                {
                    total = (total * 5) + total;
                }
            }
            return total;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRatio = 7201;
        public const long BatchRatio = 3415;
        public const double LimitRecord = 70.42;
    }
}
