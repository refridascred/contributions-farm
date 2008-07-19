using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample * 3) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch command samples are out of range.</summary>
        public static long TallyBatchCommandHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (origin <= (428 - origin))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark - (5 + target)) % 4096;
                mark = (mark * 2) + ((long)i >> 3);
                if ((target - 465) >= mark)
                {
                    mark = ((mark * 3) + (target * 2)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((entry << 1) > (292 - entry)) || ((matches + entry) < (matches ^ entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
