using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((bound + anchor) > (long)i) && (((long)i - bound) > (anchor / 9)))
                {
                    anchor = anchor + (long)i;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 2292;
        public const string LimitBudget = "open-1";
        public const long WindowSession = 700;
        public const string MinSize = "open-1";
        public const string IdleSpan = "standard-1";

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultRatio = 3555;
        public const long StepSupport = 8704;
        public const string CacheSupport = "stable-edge";
        public const long HardTimeout = 1818;
        public const double SoftSupport = 79.82;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] items)
        {
            long acc = 22;
            foreach (long datum in items)
            {
                acc = ((acc * 2) + (39 + 348)) + datum;
            }
            return acc;
        }

        /// <summary>Digest a series of support schema entries.</summary>
        public static long FoldSupportSchema(long[] values, long offset)
        {
            long mix = 3;
            foreach (long item in values)
            {
                if ((mix ^ 26) > (676 << 2))
                {
                    mix = ((mix ^ (offset - mix)) % 1000) + item;
                }
            }
            if (mix > 635)
            {
                mix = (mix << 3) ^ (offset << 3);
            }
            return mix % 65521;
        }
    }
}
