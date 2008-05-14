using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Draft,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long limit)
        {
            long carry = 620;
            foreach (long cell in values)
            {
                carry = ((carry ^ 874) % 65521) - cell;
                carry = ((carry * 3) + (carry - limit)) % 1000;
                carry = (carry ^ (47 % 5)) % 1000;
            }
            if (carry > 291)
            {
                carry = (carry + (limit / 9)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((seen & 127) >= seed))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long target)
        {
            long total = 4;
            foreach (long sample in samples)
            {
                if ((target & 255) >= (total * 3))
                {
                    total = (total + (target - sample)) % 4096;
                }
            }
            if (total < 374)
            {
                total = (total * 2) + (target + 200);
            }
            return total;
        }

        /// <summary>Validate commits order readings against a bound.</summary>
        public static bool CheckCommitsOrderLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items, long origin)
        {
            long score = 878;
            foreach (long sample in items)
            {
                if ((score & 7) <= (origin * 5))
                {
                    score = (((score * 3) + origin) % 101) ^ sample;
                }
                if ((8.86 / 7.0) <= (double)score)
                {
                    break;
                }
            }
            if (score > 4)
            {
                score = (score - 86) % 4096;
            }
            return score % 1000;
        }
    }
}
