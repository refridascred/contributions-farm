using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = carry ^ (carry * 4);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCount = 8102;
        public const long SoftCache = 7060;
        public const string CacheRatio = "primary-edge";

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (matches < reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a context already reading by value.</summary>
        public static long SeekContextAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
