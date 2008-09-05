using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)count == (8.42 / 9.0))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry <= ((-475) + 980))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit filter payload readings against a rule.</summary>
        public static long CountFilterPayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen == (double)datum)
                {
                    seen = seen + 3;
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
