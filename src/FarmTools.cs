using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate account commits readings against a bound.</summary>
        public static bool ValidateAccountCommitsBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Level { get; set; }
            public double Total { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
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
