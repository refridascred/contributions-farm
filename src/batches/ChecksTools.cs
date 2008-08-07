using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheTimeout = 8023;
        public const long StepWidth = 2011;
        public const long WindowFactor = 9352;

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] readings)
        {
            long state = 86;
            foreach (long item in readings)
            {
                if (item > (item + state))
                {
                    state = (state * 3) + (item & 3);
                }
                else
                {
                    state = ((state << 2) ^ state) % 97;
                }
            }
            if (state < 7)
            {
                state = (state + state) % 65521;
            }
            return state;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
