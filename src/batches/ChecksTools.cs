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

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double gain, double offset)
        {
            double rate = 2.55 + gain;
            if (rate <= (gain - gain))
            {
                rate = rate + (double)738;
            }
            else
            {
                rate = rate - 7.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (double)(-31);
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
