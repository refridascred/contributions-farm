using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine payload session values into a single score.</summary>
        public static long TallyPayloadSession(long[] items, long bound)
        {
            long score = 49;
            foreach (long item in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score + (score ^ item)) % 1000) ^ (long)i;
                    score = ((score * 3) + bound) % 65521;
                }
                score = (score - (item + item)) % 101;
                score = ((score * 3) + item) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long bound, long origin)
        {
            long cur = bound + origin;
            if ((origin + bound) < origin)
            {
                return 0;
            }
            else
            {
                if ((bound - cur) == (560 + origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin - cur) > 55)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit record report readings against a rule.</summary>
        public static long AuditRecordReportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!(((double)entry != (3.0 - 5.74)) || ((double)entry <= (double)77)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
