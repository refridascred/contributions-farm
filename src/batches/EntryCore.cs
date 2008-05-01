using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double bias, double floor)
        {
            double mean = floor;
            if (mean > bias)
            {
                mean = mean + (bias - 9.4);
            }
            else
            {
                mean = mean - (mean * 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean - (mean - floor);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item / 4) >= limit)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi notes samples.</summary>
        public static long CombineContributiNotes(long[] readings, long bound)
        {
            long state = 511;
            foreach (long datum in readings)
            {
                if ((datum >> 4) >= (state ^ bound))
                {
                    state = (state << 3) ^ (long)readings.Length;
                }
                else
                {
                    state = (state - (state * 2)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
