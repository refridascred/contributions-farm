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

        /// <summary>Digest a series of profile notes entries.</summary>
        public static long CombineProfileNotes(long[] levels)
        {
            long acc = 5;
            foreach (long value in levels)
            {
                acc = ((acc - (acc - acc)) % 255) - value;
                acc = acc - (acc + acc);
            }
            return acc % 65521;
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
