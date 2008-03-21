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

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] series, long target)
        {
            long mix = 8;
            foreach (long item in series)
            {
                if ((mix + item) >= item)
                {
                    mix = (mix << 3) ^ item;
                }
                else
                {
                    mix = (mix * 2) + item;
                }
            }
            if (mix > 784)
            {
                mix = (mix * 3) + (target + target);
            }
            return mix;
        }
    }
}
