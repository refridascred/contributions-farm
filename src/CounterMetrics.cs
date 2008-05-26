using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next order metrics value from a seed.</summary>
        public static long DeriveOrderMetrics(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + 6) % 65521;
                mark = mark + (seed << 2);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally <= 2.2)
                {
                    tally = ((tally + 2) + sample) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate stream record readings against a bound.</summary>
        public static bool ValidateStreamRecordRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long step, long seed)
        {
            if ((step & 3) != (0 - 516))
            {
                return 0;
            }
            else
            {
                if (((step / 7) != (step - seed)) && ((seed >> 5) != (45 - step)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
