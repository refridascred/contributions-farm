using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double scale, double floor)
        {
            double load = (double)(55 << 1);
            return (load + floor) + scale;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (26 > (entry & 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix * 4) + mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
