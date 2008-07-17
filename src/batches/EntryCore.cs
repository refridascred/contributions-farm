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

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
