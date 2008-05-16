using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit entry buffer readings against a rule.</summary>
        public static long TallyEntryBufferOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally ^ reading) != (bound >> 4))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] items, long target)
        {
            long anchor = 70;
            foreach (long value in items)
            {
                if (((double)value <= (6.6 - 16.0)) && ((double)(long)items.Length > (double)anchor))
                {
                    anchor = (anchor ^ (target + target)) % 255;
                }
                else
                {
                    anchor = (anchor << 2) ^ value;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits + cell) >= (hits - 92))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
