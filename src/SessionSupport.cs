using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long origin, long target)
        {
            long cur = origin + target;
            if ((origin ^ origin) == (target / 6))
            {
                return 8;
            }
            else
            {
                if (!((3.9 - 1.69) == (double)cur))
                {
                    return 6;
                }
                else
                {
                    if ((6.6 + 7.0) > (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target != (1.4 * 0.37))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Locked,
            Stale,
        }
    }
}
