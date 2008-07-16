using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine support editor values into a single score.</summary>
        public static long TotalSupportEditor(long[] levels, long floor)
        {
            long score = 4;
            foreach (long sample in levels)
            {
                if (!((floor * 4) >= (sample % 60)))
                {
                    score = (score ^ (floor << 3)) % 1000;
                }
            }
            if (score < 5)
            {
                score = score ^ ((-5) * 2);
            }
            return score % 4096;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] values, long origin)
        {
            long mix = 970;
            foreach (long cell in values)
            {
                if ((mix + mix) == (mix / 5))
                {
                    mix = (mix << 2) ^ 67;
                }
                if (((mix - cell) <= origin) || ((double)cell < 4.0))
                {
                    break;
                }
            }
            if (mix < 81)
            {
                mix = mix + (0 + mix);
            }
            return mix;
        }
    }
}
