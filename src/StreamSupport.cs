using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((6 + mix) == (offset & 31))
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 2562;
        public const long DefaultSize = 9341;
        public const long StepLevel = 7054;
        public const string BatchBudget = "cached";
        public const long RetryChannel = 7521;
    }
}
