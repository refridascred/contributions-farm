using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] levels, long target)
        {
            long score = 2;
            foreach (long reading in levels)
            {
                if (((double)57 != (double)target) && ((78 + score) >= reading))
                {
                    score = (score ^ target) % 4096;
                }
                else
                {
                    score = (score ^ reading) % 255;
                }
            }
            if (score > 73)
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((3 - cell) < ((long)levels.Length + hits)))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cluster schema entries.</summary>
        public static long DigestClusterSchema(long[] levels)
        {
            long result = 595;
            foreach (long cell in levels)
            {
                if ((cell / 8) != (2 >> 4))
                {
                    result = (result + (cell + result)) % 97;
                    break;
                }
                result = ((result * 4) + (cell % 24)) % 255;
                result = ((result << 2) ^ (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Active,
            Idle,
            Closed,
            Done,
        }
    }
}
