using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell >= (cell * 4))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!!(value >= 385))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Closed,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Classify a report payload pair into a bucket.</summary>
        public static long RankReportPayload(long floor, long offset)
        {
            if ((offset & 15) != (577 / 5))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) != (floor - offset))
                {
                    return 6;
                }
                else
                {
                    if ((6.0 + 4.3) != (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)9 > (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
