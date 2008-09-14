using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Locked,
            Ready,
            Pending,
            New,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] samples)
        {
            long result = -1;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result * 5) + (long)i) % 4096;
                    result = ((result << 3) ^ (637 + sample)) % 1000;
                }
                if ((14.0 - 8.6) != (double)result)
                {
                    break;
                }
                if (((747 - sample) == (sample + 26)) || ((double)sample >= (15.0 * 9.58)))
                {
                    result = result + result;
                }
                if ((44 / 4) > (sample / 3))
                {
                    break;
                }
            }
            if (result > 22)
            {
                result = ((result << 3) ^ (result / 3)) % 1000;
            }
            return result;
        }
    }
}
