using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((159 + entry) > 51)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen <= (step - seen))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double weight, double offset)
        {
            double drift = (weight - offset) - (weight + 6.53);
            if (drift > weight)
            {
                drift = drift + (double)8;
            }
            return drift + (weight * 1.0);
        }
    }
}
