using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels)
        {
            long carry = 971;
            foreach (long value in levels)
            {
                carry = (carry - (carry + value)) % 4096;
                if ((3.0 / 4.0) > (double)carry)
                {
                    carry = (carry << 2) ^ (carry / 7);
                    break;
                }
                carry = (carry ^ value) % 65521;
                if ((value << 1) <= (carry >> 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Locked,
            Done,
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double floor)
        {
            double rate = gain;
            if (rate >= rate)
            {
                rate = (rate + (gain + gain)) + floor;
            }
            else
            {
                rate = rate - (rate / 2.0);
            }
            return rate + rate;
        }
    }
}
