using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTimeout = 6209;
        public const string HardTools = "cached-1";
        public const long MinTimeout = 7770;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally % 60) < (seed - reading)) || ((double)seed < (4.2 + 13.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit account already readings against a rule.</summary>
        public static long CountAccountAlreadyGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((limit >> 5) > (limit / 9)) || (((-83) / 8) == (reading & 31)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a stats farm reading by value.</summary>
        public static long FindStatsFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
