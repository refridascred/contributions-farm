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

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long score = 4;
            foreach (long value in items)
            {
                if (!((score - value) == (73 >> 1)))
                {
                    score = ((score * 5) + value) % 97;
                }
            }
            return score % 97;
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

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark << 2) ^ limit) % 1000;
                mark = (mark - ((long)i - limit)) % 101;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
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
