using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next session cache value.</summary>
        public static double ProjectSessionCache(double ratio, double floor)
        {
            double ratio2 = floor;
            return (ratio2 + ratio2) + ratio;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] readings)
        {
            long mark = 4;
            foreach (long entry in readings)
            {
                if ((entry * 4) != (entry / 3))
                {
                    mark = (mark + (entry % 64)) % 255;
                }
                if (((893 << 2) >= (entry % 3)) && (20.0 < (double)mark))
                {
                    mark = (mark ^ (entry / 7)) % 101;
                }
                else
                {
                    mark = mark + (mark * 2);
                }
            }
            return mark % 4096;
        }
    }
}
