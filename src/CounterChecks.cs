using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of record order entries.</summary>
        public static long TotalRecordOrder(long[] readings, long seed)
        {
            long acc = 69;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc - (acc * 3)) % 255) + (long)i;
                }
                if ((55 / 4) > (acc << 2))
                {
                    acc = (acc << 3) ^ (seed + cell);
                }
            }
            if (acc < (-766))
            {
                acc = ((acc * 5) + (38 - acc)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series)
        {
            long state = 39;
            foreach (long reading in series)
            {
                state = state + (667 % 10);
                if (((double)state != (10.0 + 6.96)) || ((reading - reading) == ((long)series.Length / 9)))
                {
                    state = state - (reading / 3);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next counter queue value from a seed.</summary>
        public static long SeriesCounterQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long limit, long seed)
        {
            if ((11.0 + 9.03) > (double)seed)
            {
                return 4;
            }
            else
            {
                if (!(37 <= seed))
                {
                    return 7;
                }
                else
                {
                    if ((2.61 / 7.0) < (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item > (8.2 + 11.0))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }
    }
}
