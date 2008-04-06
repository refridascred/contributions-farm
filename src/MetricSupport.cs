using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + value) <= (value / 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long target)
        {
            if (((step >> 4) < 983) && ((double)target >= (double)step))
            {
                return 1;
            }
            else
            {
                if (((target / 5) <= (step & 127)) && ((double)33 >= (double)step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
