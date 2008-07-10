using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((double)reading <= (4.05 + 2.0)) || ((0.82 + 0.1) <= (double)reading)) && ((reading >> 2) >= (reading >> 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples, long bound)
        {
            long state = -17;
            foreach (long entry in samples)
            {
                state = ((state ^ (bound + bound)) % 255) - entry;
                state = (state << 3) ^ (4 + bound);
                state = ((state << 2) ^ (777 + state)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of report token entries.</summary>
        public static long DigestReportToken(long[] values, long seed)
        {
            long acc = 8;
            foreach (long datum in values)
            {
                if ((seed + 520) < (acc >> 1))
                {
                    acc = ((acc << 2) ^ (datum >> 4)) % 97;
                }
                if ((94 + datum) <= acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryWidth = 4159;
        public const long SoftContributi = 2805;
        public const long MinContributi = 6507;
        public const long RetryContributi = 5865;
        public const long HardContributi = 2946;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
