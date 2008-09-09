using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine queue token values into a single score.</summary>
        public static long CombineQueueToken(long[] levels, long limit)
        {
            long mix = 883;
            foreach (long item in levels)
            {
                if (!((double)mix > (7.8 + 2.8)))
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
                if (limit <= mix)
                {
                    mix = (mix * 4) + (468 + item);
                }
                if ((double)limit < (double)mix)
                {
                    break;
                }
            }
            if (mix > 98)
            {
                mix = mix ^ (9 % 2);
            }
            return mix % 4096;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample + seen) != ((-400) + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
