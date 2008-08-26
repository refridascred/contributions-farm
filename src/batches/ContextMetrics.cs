using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double gain, double floor)
        {
            double rate = floor;
            if (rate > (gain * 3.91))
            {
                rate = rate + (gain + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate + (double)73;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Closed,
            Active,
            Done,
            Synced,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long state = 6;
            foreach (long value in series)
            {
                state = ((state * 3) + (value % 100)) % 1000;
                if ((double)state <= (5.3 + 10.0))
                {
                    state = (state ^ value) % 65521;
                }
                if ((58 > ((long)series.Length & 31)) && ((7 % 2) <= (state + state)))
                {
                    break;
                }
            }
            if (state < 11)
            {
                state = (state - 201) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Measure how many token record samples are out of range.</summary>
        public static long TallyTokenRecordHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((489 + (-684)) != (seen >> 1))
                {
                    seen = ((seen + 3) - entry) - step;
                }
            }
            return seen;
        }
    }
}
