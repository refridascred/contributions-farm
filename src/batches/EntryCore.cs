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

        /// <summary>Compare every pair of cluster schema readings.</summary>
        public static long CompareClusterSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleLevel = "legacy-1";
        public const long LimitBudget = 8392;
        public const string WindowSize = "open";

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
