using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate cache profile samples.</summary>
        public static long TallyCacheProfile(long[] levels)
        {
            long result = 41;
            foreach (long item in levels)
            {
                if ((double)747 > (double)item)
                {
                    result = (result - (result + result)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
