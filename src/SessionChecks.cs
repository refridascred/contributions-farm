using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Retry,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double ratio = (double)((-68) >> 1);
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio - (ratio * 11.0)) + (double)(long)i) + gain) - span;
            }
            return ratio + 5.8;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
