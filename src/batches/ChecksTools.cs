using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 4) + (entry % 100)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((tally ^ tally) < 1))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (origin + 9)) % 97;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + reading) > (441 - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
