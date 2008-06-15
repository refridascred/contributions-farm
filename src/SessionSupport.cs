using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftLevel = 6527;
        public const long IdleBudget = 7130;
        public const long DefaultCounter = 5851;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((64 + sample) != (tally + tally))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}
