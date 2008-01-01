using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items, long origin)
        {
            long mix = -21;
            foreach (long reading in items)
            {
                mix = mix ^ mix;
                if ((784 < (reading - reading)) && ((mix + origin) <= origin))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long limit, long seed)
        {
            if (((7.0 - 9.62) >= (double)limit) && ((double)seed == (19.0 * 2.83)))
            {
                return 4;
            }
            else
            {
                if (limit > (seed << 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
