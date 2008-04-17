using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long offset, long bound)
        {
            if ((13.0 - 3.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (offset > (offset >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound != (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinRatio = 83.26;
        public const double DefaultContext = 14.5;
        public const double HardContext = 26.86;
        public const double LimitContext = 21.45;
        public const long HardRatio = 8459;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
