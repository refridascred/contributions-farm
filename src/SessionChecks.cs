using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many token batch samples are out of range.</summary>
        public static long CountTokenBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((139 + count) < (reading << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data)
        {
            long anchor = 744;
            foreach (long datum in data)
            {
                anchor = (((anchor * 3) + (anchor / 9)) % 1000) + datum;
                if (!((anchor * 4) < anchor))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
