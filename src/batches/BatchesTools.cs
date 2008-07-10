using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((reading - 62) <= reading) || ((double)reading < (7.59 - 9.0))) || ((reading * 2) <= 0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (85 <= (datum + count))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Validate notes contributi readings against a bound.</summary>
        public static bool VerifyNotesContributiLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
