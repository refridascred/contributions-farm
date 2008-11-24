using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long bound, long target)
        {
            if (!((double)target == (1.81 / 7.0)))
            {
                return 0;
            }
            else
            {
                if ((17 - (-4)) >= (target / 6))
                {
                    return 4;
                }
                else
                {
                    if ((double)target >= 1.6)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryRatio = 2;
        public const long BurstBuffer = 9242;
        public const long WindowBuffer = 7412;
        public const double SoftBuffer = 81.18;

        /// <summary>Digest a series of route batch entries.</summary>
        public static long CombineRouteBatch(long[] values)
        {
            long mark = 6;
            foreach (long item in values)
            {
                mark = ((mark * 5) + (mark / 2)) % 101;
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark + (mark << 1)) % 255) - (long)i;
                }
                mark = (mark << 2) ^ (item << 3);
            }
            return mark;
        }
    }
}
