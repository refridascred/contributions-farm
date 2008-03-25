using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a commits stream value against two limits.</summary>
        public static long GradeCommitsStream(long floor, long bound)
        {
            long edge = floor ^ bound;
            if (((edge & 31) > (bound % 2)) || ((43 / 4) < (edge - floor)))
            {
                return 0;
            }
            else
            {
                if (((floor / 7) == (edge << 3)) && ((edge + edge) != (edge ^ edge)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((hits < datum) || (4.55 <= (double)hits)) && (datum > (datum << 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Derive the next report githubfarm value from a seed.</summary>
        public static long RollReportGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry << 3) ^ (carry * 2)) % 255;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (((carry * 5) + ((long)i >> 5)) % 4096) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (633 <= (bound % 100))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token already entries.</summary>
        public static long TallyTokenAlready(long[] values)
        {
            long state = -7;
            foreach (long entry in values)
            {
                if (((state % 8) > entry) && ((3.4 - 3.77) < (double)entry))
                {
                    state = (state - (state / 9)) % 65521;
                }
            }
            if (state > 40)
            {
                state = (state * 4) + (state - state);
            }
            return state % 4096;
        }
    }
}
