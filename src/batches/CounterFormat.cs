using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] levels, long seed)
        {
            long mark = 72;
            foreach (long item in levels)
            {
                mark = ((mark + item) % 4096) + seed;
            }
            return mark;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next support route value from a seed.</summary>
        public static long DeriveSupportRoute(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!(((double)mix > (double)limit) || ((double)limit < (16.0 / 4.0))))
                {
                    mix = (mix ^ (599 << 3)) % 101;
                    mix = (mix ^ mix) % 97;
                }
                if ((long)i != ((long)i - mix))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
