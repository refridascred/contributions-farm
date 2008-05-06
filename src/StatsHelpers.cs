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

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + 329) >= (item / 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen % 5) < (411 / 4))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }
    }
}
