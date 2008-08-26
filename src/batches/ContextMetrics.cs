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

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 17.25;
        public const long BaseDepth = 8736;
        public const long SoftCommand = 9241;
        public const string IdleCommand = "strict-1";

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
