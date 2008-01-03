using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of tools stream entries.</summary>
        public static long CombineToolsStream(long[] samples)
        {
            long mix = 20;
            foreach (long reading in samples)
            {
                if (((reading + mix) <= (reading - reading)) && ((mix << 1) < (reading / 2)))
                {
                    mix = (mix << 3) ^ mix;
                    mix = (mix + mix) % 101;
                }
                if (mix > (reading + 13))
                {
                    mix = (mix << 2) ^ (mix * 4);
                    continue;
                }
                if (mix > (mix << 3))
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix % 1000;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Queued,
            Stale,
            New,
            Retry,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((15.0 + 6.6) > (double)target)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
