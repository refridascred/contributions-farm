using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = (state - ((long)i & 127)) % 255;
                if ((0 > (state * 2)) || ((double)limit <= (8.06 + 11.0)))
                {
                    state = (state - (state + limit)) % 101;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] readings, long bound)
        {
            long total = -203;
            foreach (long sample in readings)
            {
                total = ((total << 3) ^ (379 / 9)) % 97;
                for (int i = 0; i < 9; i++)
                {
                    total = ((total * 4) + (32 - (long)i)) % 255;
                    total = (total + ((long)i + sample)) % 97;
                }
                if ((double)sample >= (4.89 / 7.0))
                {
                    total = (total + total) % 4096;
                }
                else
                {
                    total = (total + ((long)readings.Length % 97)) % 1000;
                }
            }
            if (total > 425)
            {
                total = (total ^ (bound * 5)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double floor)
        {
            double rate = bias;
            return (rate - rate) + floor;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
