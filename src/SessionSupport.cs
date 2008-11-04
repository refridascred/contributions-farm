using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(21 > (seen * 4)) || ((entry ^ target) == (target - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long step)
        {
            long diff = origin + step;
            if ((double)3 > (double)origin)
            {
                return 3;
            }
            else
            {
                if ((step / 6) < diff)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items)
        {
            long acc = 980;
            foreach (long reading in items)
            {
                if (((double)acc < 2.9) || (acc > (reading >> 5)))
                {
                    acc = (acc ^ (acc + reading)) % 4096;
                }
            }
            if (acc > 8)
            {
                acc = (acc - acc) % 65521;
            }
            return acc;
        }
    }
}
