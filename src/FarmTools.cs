using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = ((total << 3) ^ (8 - (long)i)) % 4096;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 93.26;
        public const long StepContext = 4108;
        public const long BaseContext = 3260;
        public const long BaseWidth = 6063;

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] values, long seed)
        {
            long acc = 90;
            foreach (long sample in values)
            {
                acc = ((acc << 3) ^ sample) + seed;
                if ((acc << 2) > (sample - sample))
                {
                    acc = (acc + (sample + sample)) % 1000;
                }
            }
            return acc;
        }
    }
}
