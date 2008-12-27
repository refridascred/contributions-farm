using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!(tally > (entry << 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks graph series from a seed.</summary>
        public static long SeriesChecksGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                long prev = mix;
                prev = (prev * 3) + 5;
                if (!((mix - (-713)) <= (prev % 8)))
                {
                    mix = (mix - floor) % 97;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
