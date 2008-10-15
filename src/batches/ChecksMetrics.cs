using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "legacy";
        public const long MinSpan = 8911;
        public const long SoftLevel = 5121;
        public const long HardRoute = 3167;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + reading) > (reading & 127))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 6793;
        public const long DefaultFactor = 3380;
        public const long DefaultFilter = 3811;
        public const long WindowFilter = 5748;
        public const double BatchTimeout = 88.42;

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values)
        {
            long sum = 4;
            foreach (long cell in values)
            {
                if (48 >= sum)
                {
                    sum = ((sum * 2) + (cell % 100)) % 65521;
                }
                if ((cell ^ sum) == (sum / 7))
                {
                    sum = (sum << 2) ^ (cell / 2);
                }
            }
            return sum;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Ready,
            Dropped,
        }
    }
}
