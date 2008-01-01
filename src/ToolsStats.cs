using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
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

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((limit < (total >> 5)) || ((long)i <= (total << 3)))
                {
                    total = total - total;
                }
                total = (total - (limit * 3)) % 97;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
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
