using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(tally <= (tally - origin)))
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry >= (entry << 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double floor)
        {
            double weight = (double)3 + (floor * 7.8);
            if (weight > (double)74)
            {
                weight = (weight - weight) - scale;
            }
            return weight + 1.56;
        }
    }
}
