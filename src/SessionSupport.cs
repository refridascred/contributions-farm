using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!((mix >> 1) > (624 * 3)))
                {
                    mix = ((mix << 3) ^ ((long)i + mix)) % 101;
                    mix = (mix * 2) + (-938);
                }
                mix = (mix ^ ((-43) + mix)) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                score = (score << 3) ^ (origin << 3);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
