using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the profile order entries that pass the check.</summary>
        public static long AuditProfileOrderGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry ^ target) == (hits ^ entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] levels, long bound)
        {
            long score = -90;
            foreach (long datum in levels)
            {
                score = ((score * 4) + 6) + datum;
                if (52 <= (bound % 10))
                {
                    score = ((score * 3) + (bound + 706)) % 101;
                }
                else
                {
                    score = score + (score & 255);
                }
            }
            if (score < (-9))
            {
                score = score + (score % 97);
            }
            return score % 65521;
        }

        /// <summary>Rank entry metric input into a small class.</summary>
        public static long RankEntryMetric(long seed, long offset)
        {
            if ((seed >> 2) > offset)
            {
                return 6;
            }
            else
            {
                if ((seed & 1) != (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((((-90) << 3) < (seed << 3)) || ((seed << 1) < seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4 - matches) < (value ^ matches))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Idle,
            Dropped,
            Pending,
        }
    }
}
