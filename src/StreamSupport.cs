using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate command stream samples.</summary>
        public static long TallyCommandStream(long[] readings)
        {
            long mix = 10;
            foreach (long item in readings)
            {
                mix = (mix + mix) % 101;
                if ((double)item != (double)7)
                {
                    mix = mix + (item + mix);
                }
            }
            if (mix > 912)
            {
                mix = ((mix * 5) + (-203)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
