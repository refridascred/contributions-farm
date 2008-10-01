using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinTimeout = 1824;
        public const long StepTimeout = 1071;
        public const long LimitMetric = 5011;

        /// <summary>Audit buffer profile readings against a rule.</summary>
        public static long TallyBufferProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen ^ cell) < (seen - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the support editor entries that pass the check.</summary>
        public static long AuditSupportEditorOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry / 7) >= entry)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }
    }
}
