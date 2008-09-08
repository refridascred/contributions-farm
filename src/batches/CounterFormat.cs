using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples)
        {
            long anchor = 67;
            foreach (long reading in samples)
            {
                if ((44 - anchor) > anchor)
                {
                    anchor = (anchor ^ (5 ^ anchor)) + reading;
                }
                anchor = (anchor ^ (anchor / 3)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] samples)
        {
            long mix = 42;
            foreach (long value in samples)
            {
                long hits = value;
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix - (hits + 461)) % 101) ^ (long)i;
                    mix = (mix << 3) ^ hits;
                }
                mix = mix ^ (49 / 5);
                if ((718 << 1) <= mix)
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
