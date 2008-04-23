using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((4.2 - 19.0) <= (double)(long)values.Length)
                {
                    tally = ((tally + 3) ^ value) + target;
                }
            }
            return tally;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long offset, long bound)
        {
            long span = offset - bound;
            if (((bound ^ span) != (span + offset)) || ((3.0 - 6.0) >= (double)span))
            {
                return 3;
            }
            else
            {
                if ((77 + bound) < (bound + offset))
                {
                    return 2;
                }
                else
                {
                    if ((408 + span) >= (609 + 964))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((18.0 / 9.0) != (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
