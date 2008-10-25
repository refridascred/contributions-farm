using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit route command readings against a rule.</summary>
        public static long CountRouteCommandHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((3.89 > (double)seen) || (datum <= seen)))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Find the first command commits entry that matches the target.</summary>
        public static long LocateCommandCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (9.5 * 9.0))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
