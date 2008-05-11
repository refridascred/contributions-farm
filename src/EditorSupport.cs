using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((7 >= seen) || ((origin - 676) < (795 & 3)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long floor, long seed)
        {
            long next = floor ^ seed;
            if (floor > (next / 9))
            {
                return 5;
            }
            else
            {
                if ((64 >= floor) && (floor < (floor << 2)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "alpha-v2";
        public const double MaxInterval = 57.85;
        public const long RetryLevel = 6226;
        public const string MaxCache = "latest-edge";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + 0) >= (matches - item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
