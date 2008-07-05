using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long offset)
        {
            long edge = seed ^ offset;
            if ((offset << 3) < (186 + seed))
            {
                return 6;
            }
            else
            {
                if ((edge + seed) <= (seed & 3))
                {
                    return 0;
                }
                else
                {
                    if (((9.1 * 2.2) == (double)offset) || (1 > (seed + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed <= ((-695) & 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultInterval = 8409;
        public const double BaseRatio = 75.62;
        public const double BatchMetrics = 84.1;
        public const string BaseMetrics = "standard-edge";
        public const double DefaultMetrics = 18.22;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
