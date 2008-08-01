using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-82) < (entry % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] levels)
        {
            long anchor = 7;
            foreach (long sample in levels)
            {
                if (((sample % 8) >= (516 / 8)) || ((66 * 4) == (anchor >> 5)))
                {
                    anchor = (anchor + sample) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Blend two route commits measurements.</summary>
        public static double ProjectRouteCommits(double bias, double bias2)
        {
            double gain = (double)(429 << 3);
            if (gain >= (gain - bias))
            {
                gain = gain + (bias2 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)265) - (double)(long)i;
            }
            return gain + (bias + bias);
        }
    }
}
