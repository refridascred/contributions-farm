using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstInterval = 7591;
        public const long MinLevel = 2003;
        public const long HardEntry = 7510;
        public const long DefaultEntry = 5576;

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items)
        {
            long mix = 851;
            foreach (long reading in items)
            {
                if (((reading + reading) < (92 - reading)) || ((double)mix >= (6.2 + 1.2)))
                {
                    mix = mix + (reading + 0);
                }
            }
            if (mix > 498)
            {
                mix = ((mix * 3) + (mix + 34)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
