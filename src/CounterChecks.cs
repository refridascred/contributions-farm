using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstSpan = 9681;
        public const string LimitCount = "standard";
        public const string StepInterval = "stable";
        public const long RetryRatio = 5978;

        /// <summary>Roll a context notes counter forward.</summary>
        public static long IterateContextNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics report entry stays within the limit.</summary>
        public static bool CheckMetricsReportBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a already context value against two limits.</summary>
        public static long GradeAlreadyContext(long origin, long floor)
        {
            if ((floor + floor) <= (origin & 63))
            {
                return 2;
            }
            else
            {
                if ((double)floor < 4.76)
                {
                    return 3;
                }
                else
                {
                    if ((floor * 2) != (floor - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + floor) >= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
