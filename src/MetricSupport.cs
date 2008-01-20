using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((value + value) <= (hits - 443)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] series)
        {
            long anchor = 3;
            foreach (long entry in series)
            {
                anchor = (anchor ^ (anchor - anchor)) ^ entry;
            }
            if (anchor > 7)
            {
                anchor = anchor ^ (anchor / 7);
            }
            return anchor;
        }

        /// <summary>Audit contributi record readings against a rule.</summary>
        public static long MeasureContributiRecordOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally > (long)readings.Length) || (4.7 <= (18.0 - 1.0)))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }
    }
}
