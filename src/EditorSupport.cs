using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Draft,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
