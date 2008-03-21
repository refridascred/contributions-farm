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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (bound < ((long)i / 5))
                {
                    state = (state + 339) % 255;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = ((state << 2) ^ state) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
