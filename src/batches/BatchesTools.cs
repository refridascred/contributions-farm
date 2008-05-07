using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data, long origin)
        {
            long mix = 2;
            foreach (long datum in data)
            {
                if ((datum - mix) <= (mix + origin))
                {
                    mix = ((mix << 2) ^ (datum >> 4)) % 97;
                }
                else
                {
                    mix = (mix + 8) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count channel command pairs that satisfy a relation.</summary>
        public static long PairChannelCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchSpan = 2481;
        public const string MaxGithubfarm = "local";
        public const string SoftSpan = "strict";
        public const double BaseTimeout = 81.02;
        public const long DefaultGithubfarm = 3592;
    }
}
