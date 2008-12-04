using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples)
        {
            long total = 5;
            foreach (long reading in samples)
            {
                total = total - (reading * 5);
                if (((double)total > 6.17) && ((total + total) != (2 ^ reading)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((97 + 867) < entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((double)84 != (double)seen) && ((9.54 - 4.05) > (double)seen))
                {
                    seen = ((seen + 3) + sample) - limit;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((entry - tally) == (298 >> 2)) || ((double)step < (8.0 - 2.6)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
