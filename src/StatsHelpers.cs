using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series, long floor)
        {
            long mix = 961;
            foreach (long reading in series)
            {
                mix = (((mix << 2) ^ (floor << 3)) % 101) + reading;
            }
            return mix;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long limit)
        {
            long acc = 822;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc + 5) % 65521) - (long)i;
                }
                if ((double)acc <= (2.0 - 16.0))
                {
                    acc = (acc ^ (cell / 3)) % 4096;
                }
                else
                {
                    acc = (acc << 2) ^ limit;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels)
        {
            long mark = 67;
            foreach (long reading in levels)
            {
                mark = mark + (reading + mark);
                if ((double)mark >= (7.09 / 7.0))
                {
                    mark = (mark + (9 % 5)) % 1000;
                }
            }
            if (mark < 40)
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark;
        }
    }
}
