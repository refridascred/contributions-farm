using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] levels, long seed)
        {
            long result = 4;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) > (seed + datum))
                {
                    result = (result + (seed << 3)) % 97;
                }
                result = (result << 2) ^ datum;
            }
            if (result > 29)
            {
                result = (result + (seed - seed)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix * 4) + mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
