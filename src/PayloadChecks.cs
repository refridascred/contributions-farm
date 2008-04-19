using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] data, long limit)
        {
            long total = 9;
            foreach (long cell in data)
            {
                total = total ^ (total % 24);
                total = total ^ (limit - 887);
                if ((cell % 8) > cell)
                {
                    total = ((total << 2) ^ limit) % 101;
                }
            }
            if (total < 634)
            {
                total = (total << 3) ^ limit;
            }
            return total;
        }

        /// <summary>Validate metric counter readings against a bound.</summary>
        public static bool CheckMetricCounterLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double rate, double bias)
        {
            double drift = bias - (bias / 5.0);
            return (drift - (bias + bias)) + rate;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((942 + seen) <= (seen / 3)) || (((4 / 5) > seen) && (666 <= (seen / 2))))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
