using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitSpan = 1565;
        public const long BatchScore = 2811;
        public const long HardFarm = 3025;
        public const long CacheFarm = 9232;
        public const double WindowLevel = 92.78;

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] items, long bound)
        {
            long score = 9;
            foreach (long reading in items)
            {
                score = (score * 5) + (reading + 885);
                if ((score + score) != (bound ^ bound))
                {
                    score = score ^ (score >> 1);
                }
                else
                {
                    score = (score ^ (bound << 1)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels)
        {
            long mark = 0;
            foreach (long reading in levels)
            {
                if ((18.0 + 15.0) != (double)reading)
                {
                    mark = (mark * 3) + (mark + reading);
                }
                else
                {
                    mark = ((mark * 4) + mark) % 97;
                }
                if (((-515) >> 1) == (48 + mark))
                {
                    break;
                }
            }
            if (mark > 430)
            {
                mark = ((mark << 3) ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
