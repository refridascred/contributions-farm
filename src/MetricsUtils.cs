using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 8541;
        public const string SoftFarm = "primary-v2";
        public const long BaseWidth = 6917;
        public const long RetrySize = 9136;
        public const long MaxScore = 3339;

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long seed, long floor)
        {
            if (7.56 < (double)floor)
            {
                return 8;
            }
            else
            {
                if ((floor ^ seed) <= (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if (seed >= (seed + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed / 9) == (seed % 16))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
