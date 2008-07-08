using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)count > (5.4 / 8.0))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count > (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                long span = total ^ (total + (long)i);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (((total * 4) + (span / 6)) % 65521) ^ (long)i2;
                    total = total ^ (total + total);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)(long)items.Length <= (10.0 - 9.92))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
