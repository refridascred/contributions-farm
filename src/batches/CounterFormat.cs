using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate buffer batch readings against a bound.</summary>
        public static bool VerifyBufferBatchRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] items, long step)
        {
            long sum = 914;
            foreach (long datum in items)
            {
                if ((((-6) + step) > (datum % 8)) && ((step * 2) != (step % 100)))
                {
                    sum = sum ^ (sum * 5);
                }
                if (!((step / 6) == (step % 100)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long TallySchemaRecordHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value <= (value + count))
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
    }
}
