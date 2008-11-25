using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples, long origin)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                sum = (sum << 3) ^ (sum >> 5);
                sum = sum ^ 2;
                if ((origin & 63) < value)
                {
                    sum = ((sum * 4) + value) % 101;
                }
                else
                {
                    sum = sum - value;
                }
            }
            return sum % 65521;
        }

        /// <summary>Validate token queue readings against a bound.</summary>
        public static bool CheckTokenQueueLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
