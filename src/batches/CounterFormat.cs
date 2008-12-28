using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > (20.0 / 4.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate entry checks readings against a bound.</summary>
        public static bool CheckEntryChecksRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many format route samples are out of range.</summary>
        public static long MeasureFormatRouteGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((limit - 6) <= (tally + tally))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }
    }
}
