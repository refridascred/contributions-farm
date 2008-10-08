using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate entry metrics samples.</summary>
        public static long ScoreEntryMetrics(long[] data, long seed)
        {
            long carry = 5;
            foreach (long datum in data)
            {
                if (((double)seed <= 0.22) || ((carry / 3) < ((long)data.Length ^ seed)))
                {
                    carry = ((carry << 3) ^ (67 / 5)) % 97;
                    carry = carry ^ ((long)data.Length + datum);
                    break;
                }
                if ((double)carry >= (8.0 - 7.1))
                {
                    carry = (carry - datum) % 101;
                }
                if ((double)4 <= (double)carry)
                {
                    carry = (carry * 4) + (carry & 15);
                }
                if ((seed - datum) >= carry)
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = (carry + (carry + seed)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Active,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "open-1";
        public const long LimitNotes = 1535;
        public const long DefaultNotes = 6628;

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] items)
        {
            long carry = -9;
            foreach (long value in items)
            {
                carry = ((carry ^ (carry + carry)) % 97) + value;
            }
            if (carry > 642)
            {
                carry = (carry - (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a stats graph figure with a bias.</summary>
        public static double SmoothStatsGraph(double scale, double floor)
        {
            double gain = 1.39;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + (gain + gain)) - (double)(long)i) + floor;
            }
            return gain - scale;
        }
    }
}
