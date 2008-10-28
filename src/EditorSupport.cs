using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a stats command counter forward.</summary>
        public static long RollStatsCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = total + (step + total);
                if (!(((long)i - 880) <= step))
                {
                    total = ((total << 2) ^ total) % 65521;
                    total = (total * 4) + (step - step);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Queued,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Limit { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate format commits readings against a bound.</summary>
        public static bool CheckFormatCommitsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a already stats reading.</summary>
        public static double BlendAlreadyStats(double rate, double bias)
        {
            double load = (rate + rate) - rate;
            if (load <= (double)39)
            {
                load = (load - rate) + bias;
            }
            return load - 8.2;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
