using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of channel window entries.</summary>
        public static long ScoreChannelWindow(long[] series, long step)
        {
            long carry = 654;
            foreach (long datum in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = carry + ((long)series.Length << 3);
                    carry = ((carry << 3) ^ (long)i) % 1000;
                }
                carry = carry + (datum * 3);
                if ((datum - carry) <= step)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every report already entry stays within the limit.</summary>
        public static bool CheckReportAlreadyRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
