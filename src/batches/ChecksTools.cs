using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit schema profile readings against a rule.</summary>
        public static long AuditSchemaProfileHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) >= (60 << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (((8.77 / 8.0) != (double)target) && ((target + (-6)) > (score % 64)))
                {
                    score = ((score << 2) ^ (score / 4)) % 97;
                    score = (score * 3) + (target * 3);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(seen <= (cell + cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Done,
            Draft,
            Active,
            Locked,
            Ready,
        }
    }
}
