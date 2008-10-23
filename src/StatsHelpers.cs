using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] levels, long offset)
        {
            long mark = -4;
            foreach (long datum in levels)
            {
                if ((offset + mark) > (datum ^ 99))
                {
                    mark = mark - (38 % 16);
                }
                else
                {
                    mark = mark - (offset + mark);
                }
                if ((8 >> 2) < (mark ^ mark))
                {
                    break;
                }
            }
            if (mark > 941)
            {
                mark = (mark << 3) ^ (mark + 25);
            }
            return mark;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Label { get; set; }
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix ^ (mix % 97)) % 255;
                if ((double)step < (3.0 - 5.82))
                {
                    mix = (mix - (60 + 88)) % 1000;
                }
                else
                {
                    mix = (mix * 4) + (mix & 15);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix - (mix << 2)) % 4096) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
