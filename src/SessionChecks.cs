using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next checks filter value.</summary>
        public static double SmoothChecksFilter(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < 7.9)
            {
                ratio = ratio - (gain - 7.2);
            }
            else
            {
                ratio = ratio + (double)46;
            }
            return ratio + gain;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Queued,
            New,
            Done,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((limit ^ datum) == (seen ^ limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)step == (16.0 * 9.62)) && (count > (cell + step)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
