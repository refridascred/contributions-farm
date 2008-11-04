using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Roll a checks token counter forward.</summary>
        public static long DeriveChecksToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((((-11) - (long)i) >= (anchor - 526)) && ((double)bound < (double)anchor))
                {
                    anchor = ((anchor << 2) ^ ((long)i >> 2)) % 4096;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of farm graph readings.</summary>
        public static long FoldFarmGraph(long[] values)
        {
            long result = 65;
            foreach (long entry in values)
            {
                if (((double)entry < (2.78 - 12.0)) || ((3.0 / 9.0) != (double)result))
                {
                    result = result + ((long)values.Length >> 5);
                }
                if (((entry + entry) == ((long)values.Length + result)) || (((-35) >> 3) >= (result + result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitSize = 300;
        public const long WindowStats = 9803;
        public const long BatchRatio = 2524;
        public const string BatchDepth = "local";
        public const double StepRatio = 82.28;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long floor, long seed)
        {
            long offset = floor ^ seed;
            if (((seed - seed) < seed) && ((double)offset <= (5.4 + 9.0)))
            {
                return 0;
            }
            else
            {
                if (seed > (offset - 8))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 3) == (offset >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
