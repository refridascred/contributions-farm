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

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] samples)
        {
            long total = 0;
            foreach (long cell in samples)
            {
                total = (total ^ 72) + cell;
            }
            return total % 65521;
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
