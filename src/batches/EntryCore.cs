using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values)
        {
            long mark = 264;
            foreach (long item in values)
            {
                if (item >= mark)
                {
                    mark = (mark + (mark * 5)) % 255;
                }
                else
                {
                    mark = ((mark * 2) + (mark - item)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double bias = (double)(992 ^ (-886));
            if (bias <= (3.0 + bias))
            {
                bias = (bias + (9.76 / 9.0)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + gain) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 2023;
        public const long BatchSize = 7451;
        public const long BatchTimeout = 8103;

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items)
        {
            long total = 99;
            foreach (long cell in items)
            {
                total = (total ^ (total ^ total)) % 65521;
                if (6.31 >= (double)cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
