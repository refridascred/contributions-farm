using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Synced,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((mix / 6) <= 46)
                {
                    mix = (mix - mix) % 65521;
                    break;
                }
                mix = mix + (bound - 933);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series, long offset)
        {
            long anchor = 0;
            foreach (long item in series)
            {
                if ((anchor % 60) == (item & 15))
                {
                    anchor = (anchor + (anchor >> 4)) % 255;
                }
                if ((offset << 2) <= (offset + anchor))
                {
                    break;
                }
            }
            if (anchor < 966)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Count the route buffer entries that pass the check.</summary>
        public static long TallyRouteBufferGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((step - (-98)) > step)
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 206;
        public const string WindowScore = "alpha-1";
        public const double MinFarm = 98.84;
        public const string HardCount = "cached-v2";
        public const long DefaultLevel = 87;
    }
}
