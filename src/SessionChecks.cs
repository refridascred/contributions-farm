using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next record contributi value from a seed.</summary>
        public static long RollRecordContributi(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum << 2) ^ (sum ^ sum)) % 1000;
                sum = ((sum << 2) ^ (limit + limit)) % 65521;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((4.5 * 3.0) < (double)count)
                {
                    count = ((count + 3) + cell) + limit;
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
