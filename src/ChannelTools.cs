using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
