using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Failed,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitFactor = 5724;
        public const string CacheChecks = "staging-v2";
        public const long HardFactor = 80;
        public const double BatchSpan = 34.42;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window report readings.</summary>
        public static long CombineWindowReport(long[] items)
        {
            long total = 7;
            foreach (long entry in items)
            {
                if ((2.49 / 2.0) >= (double)total)
                {
                    total = ((total << 3) ^ entry) % 65521;
                }
            }
            if (total > 863)
            {
                total = ((total << 2) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            New,
            Queued,
        }
    }
}
