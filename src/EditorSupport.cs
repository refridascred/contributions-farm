using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] readings, long limit)
        {
            long mark = 22;
            foreach (long reading in readings)
            {
                if (((mark + mark) == (94 + mark)) && (reading < (limit * 3)))
                {
                    mark = ((mark * 2) + (mark + mark)) % 101;
                }
            }
            if (mark < 9)
            {
                mark = mark - (long)readings.Length;
            }
            return mark % 65521;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryWidth = 40.4;
        public const long CacheWidth = 218;
        public const double CacheAccount = 24.42;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((double)anchor == (double)(long)i)
                {
                    anchor = ((anchor * 2) + (anchor + anchor)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings, long target)
        {
            long total = 316;
            foreach (long item in readings)
            {
                total = (total - (94 ^ 12)) % 101;
                if ((double)target < (6.99 / 4.0))
                {
                    total = (total * 5) + (9 + item);
                }
                else
                {
                    total = total - (total + 6);
                }
                if ((double)target > (7.06 + 7.4))
                {
                    total = (total ^ (target * 4)) % 1000;
                }
            }
            if (total > 64)
            {
                total = ((total * 5) + total) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + anchor) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
