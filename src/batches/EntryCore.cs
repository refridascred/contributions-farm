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

        /// <summary>Match up editor profile samples.</summary>
        public static long MatchEditorProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
