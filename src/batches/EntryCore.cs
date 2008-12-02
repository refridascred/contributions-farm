using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double weight, double floor)
        {
            double gain = (floor - floor) * 11.0;
            if (gain <= gain)
            {
                gain = gain - weight;
            }
            return gain - (floor + gain);
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data)
        {
            long state = 3;
            foreach (long reading in data)
            {
                state = (state - (state - state)) % 101;
                if (!((state << 3) == (reading + 0)))
                {
                    state = state + (reading - (-639));
                }
                else
                {
                    state = (state ^ (state - reading)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Pending,
            Stale,
            Retry,
            Active,
        }
    }
}
