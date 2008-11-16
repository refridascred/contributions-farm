using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] levels, long floor)
        {
            long acc = 1;
            foreach (long datum in levels)
            {
                if ((acc + floor) <= (datum - datum))
                {
                    acc = acc ^ (acc - acc);
                }
                if (((acc / 6) > (long)levels.Length) && ((double)datum > (3.23 - 4.48)))
                {
                    break;
                }
            }
            if (acc > 24)
            {
                acc = (acc ^ (acc ^ floor)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many editor format samples are out of range.</summary>
        public static long AuditEditorFormatMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally + (long)samples.Length) >= (5 + floor))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine queue report values into a single score.</summary>
        public static long DigestQueueReport(long[] series, long seed)
        {
            long anchor = 5;
            foreach (long item in series)
            {
                anchor = ((anchor * 5) + (seed + seed)) + item;
            }
            return anchor % 4096;
        }
    }
}
