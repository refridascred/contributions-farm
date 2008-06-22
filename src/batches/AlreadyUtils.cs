using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((target + target) != (count << 2))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long step)
        {
            if (97 > limit)
            {
                return 5;
            }
            else
            {
                if (((step << 3) >= (step + step)) || ((step + limit) == (limit + step)))
                {
                    return 1;
                }
                else
                {
                    if (((double)step == (double)limit) && (step <= (step % 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)step >= 8.61) || ((limit + step) != (step % 97)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 7548;
        public const string LimitToken = "standard";
        public const double LimitSpan = 90.64;
        public const long BatchToken = 417;
        public const long WindowToken = 7037;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((origin + cell) >= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
