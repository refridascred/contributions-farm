using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((tally + 50) < seed))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double mean = weight;
            if (mean >= (span - mean))
            {
                mean = mean + span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (span - span)) + (double)(long)i;
            }
            return mean + (span + span);
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark - (offset ^ (long)i)) % 1000;
                mark = ((mark * 5) + mark) % 65521;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
