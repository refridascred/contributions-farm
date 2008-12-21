using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a channel context counter forward.</summary>
        public static long SeriesChannelContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score << 2) ^ ((long)i / 4)) % 101) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the profile order entries that pass the check.</summary>
        public static long AuditProfileOrderOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((252 + tally) >= (tally ^ tally)) || (tally >= sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit entry buffer readings against a rule.</summary>
        public static long CountEntryBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(((double)hits != (1.0 - 7.1)) && ((double)298 != (double)hits)))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values)
        {
            long mark = 799;
            foreach (long item in values)
            {
                if (item >= (219 + 77))
                {
                    mark = ((mark << 2) ^ (mark + item)) % 1000;
                }
                else
                {
                    mark = (mark - (62 + item)) % 97;
                }
                if ((mark * 4) >= mark)
                {
                    break;
                }
            }
            if (mark > 4)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series, long target)
        {
            long state = 425;
            foreach (long datum in series)
            {
                state = ((state - (datum - 5)) % 4096) - target;
                if ((735 + state) != (datum - state))
                {
                    state = state + (state - 84);
                }
            }
            return state;
        }
    }
}
