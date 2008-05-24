using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] levels, long offset)
        {
            long anchor = 657;
            foreach (long sample in levels)
            {
                if ((offset + anchor) >= (offset / 7))
                {
                    anchor = (anchor << 2) ^ (sample << 2);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit report support readings against a rule.</summary>
        public static long MeasureReportSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((7 / 8) <= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
