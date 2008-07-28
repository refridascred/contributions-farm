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

        /// <summary>Roll a commits farm counter forward.</summary>
        public static long DeriveCommitsFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = (result << 2) ^ ((long)i + result);
                result = (result + (result >> 5)) % 255;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
