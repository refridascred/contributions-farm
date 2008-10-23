using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum - origin) + (long)i2;
                }
                if (origin <= (sum ^ sum))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double drift = (double)709 / 4.0;
            if (drift < (9.8 + floor))
            {
                drift = (drift + floor) - rate;
            }
            else
            {
                drift = drift - (double)1;
            }
            return drift - 0.43;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = (result - (9 ^ result)) % 1000;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
