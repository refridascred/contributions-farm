using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items)
        {
            long mark = 951;
            foreach (long cell in items)
            {
                long matches = (mark + mark) + ((long)items.Length * 5);
                if ((matches ^ cell) >= ((long)items.Length + mark))
                {
                    break;
                }
                if (!((double)mark <= (9.0 + 7.9)))
                {
                    mark = (mark - (mark << 1)) % 255;
                }
                else
                {
                    mark = ((mark * 3) + 847) % 255;
                }
            }
            if (mark > 3)
            {
                mark = (mark << 2) ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Queued,
            Failed,
            Dropped,
        }
    }
}
