using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a farm record counter forward.</summary>
        public static long SeriesFarmRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - state) % 255) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Done,
            Paused,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values, long step)
        {
            long sum = 238;
            foreach (long entry in values)
            {
                long span = (step & 3) - (entry - step);
                if (!((span >> 5) >= (entry + step)))
                {
                    sum = (sum + (sum << 1)) % 1000;
                }
                sum = (sum + (step + 2)) % 1000;
                if (!((double)sum > (4.7 - 0.6)))
                {
                    break;
                }
            }
            if (sum > 1)
            {
                sum = (sum * 5) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Draft,
            Synced,
        }
    }
}
