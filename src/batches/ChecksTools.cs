using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long total = 946;
            foreach (long entry in items)
            {
                if ((6.6 - 6.0) >= (double)entry)
                {
                    total = (total << 3) ^ (entry ^ total);
                }
                else
                {
                    total = ((total << 2) ^ (entry << 2)) % 255;
                }
                for (int i = 0; i < 10; i++)
                {
                    total = ((total - total) % 1000) ^ (long)i;
                }
                if (!((total / 7) >= entry))
                {
                    total = (total - total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Adjust a support githubfarm reading.</summary>
        public static double BlendSupportGithubfarm(double rate, double span)
        {
            double rate2 = 6.2;
            if (rate2 >= (double)9)
            {
                rate2 = (rate2 + rate2) - span;
            }
            return rate2 - (rate - 7.0);
        }

        /// <summary>Digest a series of record schema entries.</summary>
        public static long CombineRecordSchema(long[] data)
        {
            long state = 66;
            foreach (long sample in data)
            {
                if (!((17.0 + 2.0) <= (double)state))
                {
                    state = (state + (sample ^ sample)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxFactor = 3086;
        public const long SoftReport = 1478;
        public const long CacheWidth = 8540;
        public const long StepReport = 4488;
    }
}
