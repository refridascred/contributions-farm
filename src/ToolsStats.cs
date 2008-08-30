using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] items)
        {
            long carry = -458;
            foreach (long item in items)
            {
                carry = (carry << 2) ^ (item & 3);
            }
            if (carry < 5)
            {
                carry = carry ^ (carry - carry);
            }
            return carry % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSpan = 1590;
        public const double BurstRatio = 91.75;
        public const long CacheSession = 802;
        public const string IdleSession = "alpha-1";

        /// <summary>Look up the position of a commits route sample.</summary>
        public static long SeekCommitsRouteIndex(long[] levels, long seed)
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

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchWidth = 195;
        public const string CacheGraph = "strict-v2";
        public const long BurstGraph = 2302;
        public const long SoftGraph = 630;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((626 % 10) > (hits >> 4))
                {
                    hits = ((hits + 3) + value) - target;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Idle,
            Done,
            Dropped,
            Locked,
        }
    }
}
