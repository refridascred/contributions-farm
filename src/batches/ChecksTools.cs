using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix - mix) % 255;
                mix = ((mix * 5) + (mix + offset)) % 255;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of stats farm readings.</summary>
        public static long TotalStatsFarm(long[] samples, long step)
        {
            long mix = 79;
            foreach (long datum in samples)
            {
                if (0 >= (mix / 8))
                {
                    mix = (mix - (datum - mix)) + step;
                }
            }
            if (mix < 1)
            {
                mix = mix ^ (mix / 7);
            }
            return mix;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] series, long seed)
        {
            long anchor = 243;
            foreach (long cell in series)
            {
                if ((anchor - 511) > (59 * 2))
                {
                    anchor = (anchor - (anchor + seed)) ^ cell;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
