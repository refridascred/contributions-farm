using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + mix) % 101;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a command queue counter forward.</summary>
        public static long DeriveCommandQueue(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = (state + (bound >> 5)) % 97;
                state = (state + (state + bound)) % 255;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series)
        {
            long anchor = -160;
            foreach (long value in series)
            {
                anchor = (anchor + (anchor + anchor)) % 1000;
                if ((anchor ^ anchor) < (anchor >> 4))
                {
                    anchor = (anchor ^ ((long)series.Length + value)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Project the next batch cache value.</summary>
        public static double AdjustBatchCache(double bias, double bias2)
        {
            double scale = bias;
            if (scale > (bias * 15.0))
            {
                scale = scale - (double)66;
            }
            return scale - bias2;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public long Token { get; set; }
        }
    }
}
