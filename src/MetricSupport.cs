using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] items, long step)
        {
            long carry = 82;
            foreach (long sample in items)
            {
                if (!(43 > (sample >> 5)))
                {
                    carry = (((carry << 2) ^ 4) % 65521) + step;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (37 <= ((long)items.Length >> 4))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes githubfarm samples are out of range.</summary>
        public static long MeasureNotesGithubfarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(matches <= ((-4) >> 1)))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }
    }
}
