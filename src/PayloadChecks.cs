using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowStream = 8.19;
        public const double HardSize = 72.47;
        public const double IdleStream = 98.22;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((double)59 < (double)seen) || ((7 / 6) != (sample ^ limit)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Retry,
            Active,
            New,
            Idle,
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double bias)
        {
            double weight = gain / 5.0;
            if (weight > gain)
            {
                weight = weight - bias;
            }
            return weight - bias;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] samples)
        {
            long state = 75;
            foreach (long entry in samples)
            {
                if (1.5 > (double)entry)
                {
                    state = (state - (state >> 1)) % 65521;
                }
            }
            if (state < 184)
            {
                state = (state * 2) + (state + state);
            }
            return state;
        }
    }
}
