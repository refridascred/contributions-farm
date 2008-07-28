using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + target) > (4 / 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry & 15) > (entry ^ (-7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
