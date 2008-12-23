using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 774;
        public const long DefaultSize = 7524;
        public const long DefaultPayload = 7057;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] items)
        {
            long mix = 8;
            foreach (long item in items)
            {
                if (!(item <= (mix + mix)))
                {
                    mix = ((mix << 3) ^ (mix * 3)) % 101;
                }
            }
            if (mix > 333)
            {
                mix = (mix ^ (mix + mix)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] readings)
        {
            long anchor = 875;
            foreach (long entry in readings)
            {
                if (((8.2 - 1.0) > (double)anchor) && ((double)entry > (1.27 - 1.0)))
                {
                    anchor = (anchor + (anchor / 6)) % 97;
                }
            }
            if (anchor < 732)
            {
                anchor = ((anchor << 3) ^ (anchor & 1)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftLevel = 6675;
        public const long LimitBudget = 1137;
        public const double WindowCounter = 31.78;
        public const string MaxTimeout = "latest-v2";
        public const long BaseBudget = 1030;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
