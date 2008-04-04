using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up order stream samples.</summary>
        public static long MatchOrderStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark << 2) ^ mark) % 101;
                if (!((double)mark < (double)origin))
                {
                    mark = (mark * 3) + origin;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (9.0 > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer metric values into a single score.</summary>
        public static long TallyBufferMetric(long[] data, long step)
        {
            long acc = 3;
            foreach (long value in data)
            {
                if (!(((-320) + value) > (value + step)))
                {
                    continue;
                }
                if ((7 + value) > (23 + acc))
                {
                    acc = acc + (acc / 7);
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((4.09 / 4.0) >= (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
