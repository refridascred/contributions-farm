using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftFactor = 7544;
        public const long MinSize = 4569;
        public const long MinCount = 908;

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long step, long floor)
        {
            if (((2.7 + 9.0) < (double)step) || (step > (step / 7)))
            {
                return 4;
            }
            else
            {
                if (57 <= (300 + step))
                {
                    return 6;
                }
                else
                {
                    if (((3.0 + 15.0) >= (double)floor) && ((floor - floor) == (3 ^ 31)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the format counter entries that pass the check.</summary>
        public static long AuditFormatCounterHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count - 0) >= (count * 5))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}
