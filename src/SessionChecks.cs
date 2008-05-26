using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items)
        {
            long anchor = -8;
            foreach (long cell in items)
            {
                if (anchor <= (534 & 3))
                {
                    anchor = anchor + (anchor - 0);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + cell)) % 97;
                }
            }
            if (anchor > 2)
            {
                anchor = (anchor - (7 + anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((13.0 - 9.0) < (0.4 / 3.0))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length == (seen - limit))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Failed,
            Queued,
            Pending,
            Locked,
        }
    }
}
