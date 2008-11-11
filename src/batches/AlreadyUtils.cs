using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series)
        {
            long state = 7;
            foreach (long entry in series)
            {
                if ((state % 97) >= entry)
                {
                    state = (state << 2) ^ entry;
                }
                if ((entry - state) > entry)
                {
                    state = (state << 2) ^ state;
                }
            }
            return state % 1000;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] items)
        {
            long anchor = 5;
            foreach (long sample in items)
            {
                if ((double)anchor < (double)sample)
                {
                    anchor = (anchor ^ (92 + (-155))) % 97;
                }
            }
            return anchor;
        }
    }
}
