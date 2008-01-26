using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double scale2 = scale + (scale - bias);
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (scale + scale2)) + (double)(long)i;
            }
            return scale2 - (scale - 2.3);
        }

        /// <summary>Classify a entry buffer pair into a bucket.</summary>
        public static long RankEntryBuffer(long origin, long target)
        {
            long lane = origin + target;
            if (((target + lane) >= target) && ((origin >> 1) >= (target / 4)))
            {
                return 4;
            }
            else
            {
                if ((double)lane < (0.28 + 4.0))
                {
                    return 0;
                }
                else
                {
                    if ((lane << 3) != (lane & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin / 4) == (lane + lane)))
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

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Failed,
            Locked,
            Stale,
        }
    }
}
