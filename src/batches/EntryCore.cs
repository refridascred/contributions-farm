using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of token context readings.</summary>
        public static long PairTokenContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits metrics samples.</summary>
        public static long TotalCommitsMetrics(long[] series, long limit)
        {
            long carry = 541;
            foreach (long item in series)
            {
                carry = carry + (limit - item);
                if ((1.06 - 0.43) >= (double)item)
                {
                    carry = ((carry * 3) + (carry + item)) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Derive the next cluster command value from a seed.</summary>
        public static long DeriveClusterCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 2) ^ origin) % 65521;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Active,
            Failed,
        }
    }
}
