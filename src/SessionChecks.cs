using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (14.0 * 3.8))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] series, long seed)
        {
            long score = -687;
            foreach (long cell in series)
            {
                score = (score << 3) ^ (cell + seed);
                if (!((cell + seed) < (-74)))
                {
                    score = (score * 2) + (score + 782);
                    score = ((score * 4) + (cell * 5)) % 101;
                }
                if ((18.0 - 5.6) >= (double)score)
                {
                    score = ((score << 2) ^ cell) % 65521;
                }
                else
                {
                    score = (score + (cell + cell)) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Idle,
            Failed,
            Draft,
            Stale,
        }
    }
}
