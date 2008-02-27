using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

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
