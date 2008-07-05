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

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double gain = (double)(256 ^ 700);
            return (gain - (gain - ratio)) + floor;
        }

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
