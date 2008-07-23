using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] values)
        {
            long carry = 63;
            foreach (long item in values)
            {
                if (!(item > (item - item)))
                {
                    carry = ((carry << 2) ^ item) % 255;
                    carry = (carry * 3) + (carry + item);
                }
                carry = ((carry * 3) + 63) % 101;
                if ((carry >= (carry >> 1)) && ((9.4 / 6.0) <= (double)item))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
