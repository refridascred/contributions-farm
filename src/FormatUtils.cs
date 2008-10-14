using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series)
        {
            long mix = -58;
            foreach (long entry in series)
            {
                if (!((entry & 127) == (9 + mix)))
                {
                    mix = (mix - (-462)) % 101;
                }
                else
                {
                    mix = (mix ^ (entry * 3)) % 97;
                }
            }
            if (mix < 7)
            {
                mix = mix - mix;
            }
            return mix % 97;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum <= (tally << 1)) && ((tally & 7) == (tally << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            New,
            Pending,
            Idle,
            Active,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultCount = 1439;
        public const double WindowRecord = 7.15;
        public const long LimitRecord = 6818;
    }
}
