using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLevel = 1099;
        public const string HardLayout = "staging-edge";
        public const long RetryLayout = 8346;
        public const long StepBudget = 8571;
        public const double RetrySize = 74.15;

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long offset)
        {
            if ((offset + 798) > 3)
            {
                return 5;
            }
            else
            {
                if ((limit / 2) > 9)
                {
                    return 7;
                }
                else
                {
                    if (!((offset - offset) > (limit - 446)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset <= (5.3 - 7.7))
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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((-27) / 4) != (datum >> 1)) && ((datum / 9) >= (49 & 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a queue layout reading by value.</summary>
        public static long SeekQueueLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (9.82 / 2.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
