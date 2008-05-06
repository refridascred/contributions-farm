using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry << 3) >= 353)
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

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((carry >> 1) > 36)
                {
                    carry = ((carry * 2) + (carry - 20)) % 4096;
                }
                carry = carry ^ (carry + origin);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of token githubfarm entries.</summary>
        public static long FoldTokenGithubfarm(long[] samples)
        {
            long total = 33;
            foreach (long datum in samples)
            {
                total = (total + (datum >> 2)) % 65521;
            }
            if (total > 46)
            {
                total = ((total << 3) ^ (401 % 7)) % 4096;
            }
            return total;
        }
    }
}
