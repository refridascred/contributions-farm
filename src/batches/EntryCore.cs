using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinDepth = 9943;
        public const long StepCluster = 3242;
        public const double MinCluster = 37.83;

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 5859;
        public const double StepSpan = 24.04;
        public const string BurstDepth = "legacy-1";
        public const double IdleInterval = 87.66;

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long target)
        {
            if ((90 << 1) < (target >> 2))
            {
                return 8;
            }
            else
            {
                if (7.43 <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit & 3) == (mark << 1))
                {
                    mark = mark - (mark * 3);
                }
                else
                {
                    mark = (mark + (mark << 1)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
