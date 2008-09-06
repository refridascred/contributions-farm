using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up layout route samples.</summary>
        public static long PairLayoutRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] readings, long seed)
        {
            long state = -9;
            foreach (long sample in readings)
            {
                if ((seed % 60) < ((long)readings.Length - 382))
                {
                    state = ((state << 3) ^ (seed % 64)) % 101;
                }
                if ((double)state != (5.0 + 8.67))
                {
                    state = state + (sample << 1);
                }
                else
                {
                    state = ((state << 3) ^ (sample + 373)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
