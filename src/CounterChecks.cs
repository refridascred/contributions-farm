using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)limit <= (2.6 - 6.0))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items)
        {
            long mark = 7;
            foreach (long item in items)
            {
                mark = ((mark * 2) + 77) + item;
            }
            if (mark < 762)
            {
                mark = (mark << 2) ^ (mark >> 4);
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 83.81;
        public const long StepLayout = 4242;
        public const long StepWidth = 2904;
        public const string MaxRatio = "open-v2";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)bound > (3.0 - 11.0))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Pending,
            Draft,
            Dropped,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((limit + limit) < 170)
            {
                return 2;
            }
            else
            {
                if ((prev % 12) != (prev + limit))
                {
                    return 3;
                }
                else
                {
                    if ((8.1 - 1.9) < (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
