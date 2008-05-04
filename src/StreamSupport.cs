using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((entry + matches) <= (matches + entry)) && ((double)9 > (double)matches)) || !((double)matches <= 7.81))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric stream samples are out of range.</summary>
        public static long CountMetricStreamHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell % 7) <= (hits & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile context readings.</summary>
        public static long ScoreProfileContext(long[] samples, long floor)
        {
            long anchor = 3;
            foreach (long reading in samples)
            {
                if ((273 - reading) > (reading + anchor))
                {
                    anchor = ((anchor << 3) ^ floor) % 65521;
                }
                else
                {
                    anchor = (anchor - 56) % 65521;
                }
            }
            return anchor % 4096;
        }
    }
}
