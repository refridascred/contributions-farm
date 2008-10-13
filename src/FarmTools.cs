using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long target)
        {
            if (!((0.4 + 1.57) != (double)target))
            {
                return 1;
            }
            else
            {
                if (((target ^ floor) > (7 / 2)) || (floor >= (target << 3)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample <= ((long)readings.Length % 7))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long mix = 6;
            foreach (long datum in readings)
            {
                mix = (((mix * 3) + (93 + (long)readings.Length)) % 255) - datum;
                if (((-68) - mix) > mix)
                {
                    mix = mix ^ (mix + mix);
                }
            }
            return mix;
        }
    }
}
